using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;

namespace SerialPortUsing {
	public partial class SecurityForm : Form {

		UIDCOMListener _listener;
		private Access_control_in_OneWire.StaffDataTable _table; // Экземпляр таблички подключенного источника данных
		private StaffTableAdapter _staffTableAdapter; // Экземпляр класса адаптера одной из таблиц. (Лежит в SerialPortUsing.AC_DataSetTableAdapters)
		private const string UID_FILTER = "Uid='{0}'"; // Выражение-фильтр синтаксиса "DataView RowFilter Syntax" http://www.csharp-examples.net/dataview-rowfilter/

		#region Structing
		public SecurityForm() {
			_table = new Access_control_in_OneWire.StaffDataTable();
			_staffTableAdapter = new StaffTableAdapter();
			_staffTableAdapter.ClearBeforeFill = true;
			_staffTableAdapter.Fill(_table);

			try{
				_listener = new UIDCOMListener(Properties.Settings.Default.COMName, Properties.Settings.Default.BaudRate, 8, _listener_UIDReceived);
			}
			catch(Exception)
			{
				MessageBox.Show(this, "Не удалось получить доступ к COM-порту.", "Ошибка");
				this.Close();
				return;
			}
			
			InitializeComponent();
			this.CenterToScreen();
		}

		private void SecurityForm_Load(object sender, EventArgs e) {
			try {
				if (_table.IsInitialized){Application.DoEvents();}
			}
			catch (Exception er) {
				MessageBox.Show(this, er.ToString(), "ЕГГОГ");
				this.Close();
			}
		}
		#endregion

		private void _listener_UIDReceived(object sender, string uid) {
			System.Data.DataRow[] searchResult; // Массив строк, который получим от поиска по таблице
			searchResult = _table.Select(String.Format(UID_FILTER, uid)); // Выбор строк, удовлетворяющих условиям, заданным в строке-фильтре

			if(searchResult.Length != 0){
				if (searchResult.Length > 0)
					MessageBox.Show(this, "Дубликаты UID!", "АААА!!!");
				ShowFace(	searchResult[0][1].ToString(), searchResult[0][10].ToString(), 
							searchResult[0][3].ToString(), searchResult[0][8].ToString(), 
							searchResult[0][6].ToString(), searchResult[0][0].ToString(),
							searchResult[0][9].ToString(), 0);
			}
			else
				MessageBox.Show(null, "Предъявлен неизвестный UID!\n"+uid, "ВНИМАНИЕ");
				ShowFace("", "", "", "", "", "", "", 0);
		}

		delegate void ShowFaceCallBack(string picturePath, string fio, string number, string division, string shedule, string profession, string uidType, int ttl);
		public void ShowFace(string picturePath, string fio, string number, string division, string shedule, string profession, string uidType, int ttl) {
			if(pic_face.InvokeRequired) {
				ShowFaceCallBack cb = ShowFace;
				this.Invoke(cb,  picturePath,  fio,  number,  division,  shedule,  profession,  uidType, ttl);
				return;
			}
			
			try { pic_face.Image = new Bitmap(picturePath); }
			catch(Exception) {
				MessageBox.Show(null, "Файл фотографии сотрудника не найден!", "Ошибка");
			}
			l_fio.Text = fio;

			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.TopMost = true;
			this.CenterToScreen();

			if(ttl>0){
				Timer tmr = new Timer { Interval = ttl };
				tmr.Start();
				tmr.Tick += tmr_Tick;
			}

		}

		private void tmr_Tick(object sender, EventArgs e) {
			this.HideFace();
		}
		public void HideFace() {
			this.Hide();
		}

		#region Experimenting
		private void cB_testButton_Click(object sender, EventArgs e) {
			
		}
		#endregion

		private void SecurityForm_FormClosing(object sender, FormClosingEventArgs e) {
			_listener.Close();
		}
	}
}

//
// "Дэн Дэн\nДэн Денис!"