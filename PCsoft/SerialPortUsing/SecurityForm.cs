using System;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;

namespace SerialPortUsing {

	public partial class SecurityForm : Form {
		#region Constants
		private const string UID_FILTER = "Uid='{0}'"; // Выражение-фильтр синтаксиса "DataView RowFilter Syntax" http://www.csharp-examples.net/dataview-rowfilter/
		#endregion

		#region Serving Objects
		UIDCOMDialog _dialog;
		#endregion

		#region Tables and adapters
		private Access_control_in_OneWire.StaffDataTable _staffTable; // Экземпляр таблички подключенного источника данных
		private Access_control_in_OneWire.ScheduleDataTable _shTable;
		private StaffTableAdapter _staffTableAdapter; // Экземпляр класса адаптера одной из таблиц. (Лежит в SerialPortUsing.AC_DataSetTableAdapters)
		private ScheduleTableAdapter _shAdapter = new ScheduleTableAdapter();
		private JoinedEventLogAdapter _eventLogAdapter;
		#endregion

		#region Structing
		public SecurityForm() {
			_staffTable = new Access_control_in_OneWire.StaffDataTable();
			_staffTableAdapter = new StaffTableAdapter();
			_staffTableAdapter.ClearBeforeFill = true;
			_staffTableAdapter.Fill(_staffTable);

			_eventLogAdapter = new JoinedEventLogAdapter();
			_eventLogAdapter.ClearBeforeFill = true;
			_eventLogAdapter.Adapter.InsertCommand.Connection = _eventLogAdapter.Connection;

			_shAdapter.ClearBeforeFill = true;
			_shTable = new Access_control_in_OneWire.ScheduleDataTable();
			//try{
				_dialog = new UIDCOMDialog(Properties.Settings.Default.COMName, Properties.Settings.Default.BaudRate, 8, _listener_UIDReceived);
			//}
			//catch(Exception)
			//{
			//	MessageBox.Show(this, "Не удалось получить доступ к COM-порту.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	this.Close();
			///	return;
			//}
			
			InitializeComponent();
			this.CenterToScreen();
		}

		private void SecurityForm_Load(object sender, EventArgs e) {
			try {
				if (_staffTable.IsInitialized){Application.DoEvents();}
			}
			catch (Exception er) {
				MessageBox.Show(this, er.ToString(), "ЕГГОГ", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
		#endregion

		private void _listener_UIDReceived(object sender, string uid, bool enterExit)
		{
			//MessageBox.Show(enterExit.ToString());
			System.Data.DataRow[] searchResult; // Массив строк, который получим от поиска по таблице
			searchResult = _staffTable.Select(String.Format(UID_FILTER, uid)); // Выбор строк, удовлетворяющих условиям, заданным в строке-фильтре

			if(searchResult.Length != 0){
				
				StaffOutputInfo staffInfo = new StaffOutputInfo((Access_control_in_OneWire.StaffRow)searchResult[0]);

				ShowFace(staffInfo, 0, enterExit);
				WriteEventToLog(uid, enterExit);

				if (searchResult.Length > 1)
					MessageBox.Show(null, "Дубликаты UID!", "АААА!!!"); // Time to shit bricks
				else {
					_dialog.SendCommand(ACCommand.OpenAndRead);
				}
			}
			else{
				MessageBox.Show(null, "Предъявлен неизвестный UID!\n" + uid, "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ShowFace(null, 0, enterExit);
			}
		}

		int CompareHoursAndMinutes(DateTime d1, DateTime d2)
		{
			if(d1.Hour > d2.Hour) return -1;
			else if (d1.Hour == d2.Hour)
				if (d1.Minute > d2.Minute) return -1;
				else if (d1.Minute == d2.Minute) return 0;
			return 1;
		}

		private void WriteEventToLog(string uid, bool enterExit) {
			if (enterExit){
				_eventLogAdapter.Adapter.UpdateCommand.Parameters[0].Value = uid;
				_eventLogAdapter.Adapter.UpdateCommand.Connection.Open();
				_eventLogAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
				_eventLogAdapter.Adapter.UpdateCommand.Connection.Close();
			}
			else{
				_eventLogAdapter.Adapter.InsertCommand.Parameters[0].Value = uid;
				_eventLogAdapter.Adapter.InsertCommand.Connection.Open();
				_eventLogAdapter.Adapter.InsertCommand.ExecuteNonQuery();
				_eventLogAdapter.Adapter.InsertCommand.Connection.Close();
			}
		}

		delegate void ShowFaceCallBack(StaffOutputInfo staffInfo, int ttl, bool enterExit);
		public void ShowFace(StaffOutputInfo staffInfo, int ttl, bool enterExit)
		{
			if(pic_face.InvokeRequired) {
				ShowFaceCallBack cb = ShowFace;
				this.Invoke(cb,  staffInfo, ttl, enterExit);
				return;
			}
			ShowFace_Invoked(staffInfo, ttl, enterExit);
		}
		private void ShowFace_Invoked(StaffOutputInfo staffInfo, int ttl, bool enterExit)
		{
			if (staffInfo == null) { FlushFields(); return; }

			try { pic_face.Image = new Bitmap(staffInfo.PicturePath); }
			catch (Exception e) {
				MessageBox.Show(null, e.Message, "Ошибка");
			}

			bool notInTime = true;
			#region CheckingTime
			_shAdapter.Fill(_shTable, staffInfo.Shedule);
			DateTime start;
			DateTime fin;
			DateTime.TryParse(_shTable.Rows[0][0].ToString(), out start);
			DateTime.TryParse(_shTable.Rows[0][1].ToString(), out fin);

			if (CompareHoursAndMinutes(DateTime.Now, fin) == 1 && CompareHoursAndMinutes(DateTime.Now, start) == -1) {
				notInTime = false;
			}
			#endregion

			l_fio.Text = staffInfo.Fio;
			l_division.Text = staffInfo.Division;
			l_number.Text = staffInfo.Number;
			l_profession.Text = staffInfo.Profession;
			l_shedule.Text = staffInfo.Shedule;
			l_uidType.Text = staffInfo.UidType;
			l_actionTime.Text = DateTime.Now.ToString();
			if(enterExit)
				l_action.Text = "Выход";
			else
				l_action.Text = "Проход";

			l_NotInTime.Visible = notInTime;
			l_blocked.Visible = staffInfo.Blocked;

			this.WindowState = FormWindowState.Minimized;
			this.WindowState = FormWindowState.Normal;
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.Focus();
			this.CenterToScreen();
			if (ttl > 0) {
				Timer tmr = new Timer { Interval = ttl };
				tmr.Start();
				tmr.Tick += tmr_Tick;
			}
		}

		void FlushFields(){
			pic_face.Image = null;
			l_fio.Text = "";
			l_division.Text = "";
			l_number.Text = "";
			l_profession.Text = "";
			l_shedule.Text = "";
			l_uidType.Text = "";
			l_actionTime.Text = "";
			l_action.Text = "";
			l_NotInTime.Visible = false;
			l_blocked.Visible = false;
		}

		private void tmr_Tick(object sender, EventArgs e) {
			this.HideFace();
		}
		public void HideFace() {
			this.Hide();
		}
		private void SecurityForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_dialog.Close();
		}

		#region Experimenting
		private void cB_testButton_Click(object sender, EventArgs e) {
			
		}
		#endregion

		
	}

	public class StaffOutputInfo
	{
		public string Fio;
		public string Number;
		public string Division;
		public string Shedule;
		public string Profession;
		public string UidType;
		public string PicturePath;
		public bool Blocked;
		public StaffOutputInfo(Access_control_in_OneWire.StaffRow row)
		{
			Profession = row[0].ToString();
			PicturePath = row[1].ToString();
			Number = row[3].ToString();
			Shedule = row[6].ToString();
			Blocked = Convert.ToBoolean(row[7].ToString());
			Division = row[8].ToString();
			UidType = row[9].ToString();
			Fio = row[10].ToString();
		}
	}

}