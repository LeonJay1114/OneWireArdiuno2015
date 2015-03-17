using System;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;

namespace SerialPortUsing {
	public partial class SecurityForm : Form {

		UIDCOMListener _listener;
		private Access_control_in_OneWire.StaffDataTable _staffTable; // Экземпляр таблички подключенного источника данных
		private Access_control_in_OneWire.ScheduleDataTable _shTable;
		private StaffTableAdapter _staffTableAdapter; // Экземпляр класса адаптера одной из таблиц. (Лежит в SerialPortUsing.AC_DataSetTableAdapters)
		private ScheduleTableAdapter _shAdapter = new ScheduleTableAdapter();
		private Access_control_in_OneWire.simpleEventLogDataTable _eventTable;
		private JoinedEventLogAdapter _eventLogAdapter;
		
		private const string UID_FILTER = "Uid='{0}'"; // Выражение-фильтр синтаксиса "DataView RowFilter Syntax" http://www.csharp-examples.net/dataview-rowfilter/

		

		#region Structing
		public SecurityForm() {
			_staffTable = new Access_control_in_OneWire.StaffDataTable();
			_staffTableAdapter = new StaffTableAdapter();
			_staffTableAdapter.ClearBeforeFill = true;
			_staffTableAdapter.Fill(_staffTable);

			_eventTable = new Access_control_in_OneWire.simpleEventLogDataTable();
			_eventLogAdapter = new JoinedEventLogAdapter();
			_eventLogAdapter.ClearBeforeFill = true;
			_eventLogAdapter.Adapter.InsertCommand.Connection = _eventLogAdapter.Connection;

			_shAdapter.ClearBeforeFill = true;
			//try{
				_listener = new UIDCOMListener(Properties.Settings.Default.COMName, Properties.Settings.Default.BaudRate, 8, _listener_UIDReceived);
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
			
			bool notInTime = false;
			_shTable = new Access_control_in_OneWire.ScheduleDataTable();

			_shAdapter.Fill(_shTable, searchResult[0][6].ToString());
			DateTime start;
			DateTime fin;
			DateTime.TryParse(_shTable.Rows[0][0].ToString(), out start);
			DateTime.TryParse(_shTable.Rows[0][1].ToString(), out fin);
			if (DateTime.Now < fin & DateTime.Now > start)
			{
				notInTime = false;
			}
			else
			{
				notInTime = true;
			}
			if(searchResult.Length != 0){
				if (searchResult.Length > 1)
					MessageBox.Show(null, "Дубликаты UID!", "АААА!!!"); // Time to shit bricks
				ShowFace(searchResult[0][1].ToString(), searchResult[0][10].ToString(), searchResult[0][3].ToString(), searchResult[0][8].ToString(), searchResult[0][6].ToString(), notInTime, searchResult[0][0].ToString(), searchResult[0][9].ToString(), 0, enterExit);
				WriteEventToLog(uid, enterExit);
			}
			else{
				MessageBox.Show(null, "Предъявлен неизвестный UID!\n" + uid, "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				ShowFace("", "", "", "", "", notInTime, "", "", 0, enterExit);
			}
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

		delegate void ShowFaceCallBack(string picturePath, string fio, string number, string division, string shedule, bool notTimed, string profession, string uidType, int ttl, bool enterExit);
		public void ShowFace(string picturePath, string fio, string number, string division, string shedule, bool notTimed, string profession, string uidType, int ttl, bool enterExit)
		{
			if(pic_face.InvokeRequired) {
				ShowFaceCallBack cb = ShowFace;
				this.Invoke(cb,  picturePath,  fio,  number,  division,  shedule, notTimed, profession,  uidType, ttl, enterExit);
				return;
			}
			ShowFace_Invoked(picturePath,  fio,  number,  division,  shedule,  notTimed, profession,  uidType, ttl, enterExit);
		}
		private void ShowFace_Invoked(string picturePath, string fio, string number, string division, string shedule, bool notTimed, string profession, string uidType, int ttl, bool enterExit)
		{
			if (fio == "") {FlushFields(); return;}

			try { pic_face.Image = new Bitmap(picturePath); }
			catch (Exception e) {
				//MessageBox.Show(null, e.Message, "Ошибка");
			}
			l_fio.Text = fio;
			l_division.Text = division;
			l_number.Text = number;
			l_profession.Text = profession;
			l_shedule.Text = shedule;
			l_uidType.Text = uidType;
			l_actionTime.Text = DateTime.Now.ToString();
			if(enterExit) {
				l_action.Text = "Выходит";
			}
			else {
				l_action.Text = "Входит";
			}


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
		}

		private void tmr_Tick(object sender, EventArgs e) {
			this.HideFace();
		}
		public void HideFace() {
			this.Hide();
		}
		private void SecurityForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_listener.Close();
		}

		#region Experimenting
		private void cB_testButton_Click(object sender, EventArgs e) {
			
		}
		#endregion

		
	}
}

//
// "Дэн Дэн\nДэн Денис!"