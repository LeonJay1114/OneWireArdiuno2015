using System;
//using System.Linq;
using System.Windows.Forms;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;

namespace SerialPortUsing {
	public partial class Authorisation : Form {

		// Компонент-драйвер базы Access: http://www.microsoft.com/en-us/download/confirmation.aspx?id=23734

		private Access_control_in_OneWire.SystemUsersDataTable _usersTable; // Экземпляр таблички подключенного источника данных
		private SystemUsersTableAdapter _sysUsersTableAdapter; // Экземпляр класса адаптера одной из таблиц. (Лежит в SerialPortUsing.AC_DataSetTableAdapters)
		private const string LOGIN_PASS_FILTER = "login='{0}'"; // Выражение-фильтр синтаксиса "DataView RowFilter Syntax" http://www.csharp-examples.net/dataview-rowfilter/
		// TODO: Это всё хуйня, надо пилить красотищу про хэши и соли.

		public Authorisation() {
			InitializeComponent();

			_usersTable = new Access_control_in_OneWire.SystemUsersDataTable(); // Инициализируем табличку
			_sysUsersTableAdapter = new SystemUsersTableAdapter(); // Инициализируем адаптер таблицы
			_sysUsersTableAdapter.ClearBeforeFill = true; // Говорим нашему адаптеру таблицы, чтобы очищал таблицу перед заполнением

			_usersTable = _sysUsersTableAdapter.GetData(); // Дастаём таблицу из базы и кладём в свой адаптер базы
		}

		#region TestDB connection
		private void Autorization_Load(object sender, EventArgs e) {
			try {
				if (_usersTable.IsInitialized)
					CheckConnection.Text = "Connection OK!";
			}
			catch (Exception er) {
				MessageBox.Show(this, er.ToString(), "ЕГГОГ");
			}
		}
		#endregion

		private void Btn_Enter_Click(object sender, EventArgs e) {

			//Login("Admin");
			//return;
			
			string uName = tB_username.Text;
			string uPass = tB_password.Text;

			System.Data.DataRow[] searchResult; // Массив строк, который получим от поиска по таблице
			searchResult = _usersTable.Select(String.Format(LOGIN_PASS_FILTER, uName)); // Выбор строк, удовлетворяющих условиям, заданным в строке-фильтре LOGIN_PASS_FILTER
			int count = searchResult.Length;

			if (count == 0) {
				MessageBox.Show(this, "Введенная пара логин-пароль отсутствует в базе данных. Обратитесь к системному администратору.", "Ошибка");
				return;
			}

			string login = searchResult[0][0].ToString();
			string enteredPass = tB_password.Text;
			string hash = searchResult[0][2].ToString();
			string salt = searchResult[0][3].ToString();

			if (CheckPass(enteredPass, hash, salt)){
				Login(login);
			}
			else {
				MessageBox.Show(this, "Введенная пара логин-пароль отсутствует в базе данных. Обратитесь к системному администратору.", "Ошибка");
			}
		}

		bool CheckPass(string pass, string hashe, string salt)
		{
			return SHA512.CheckPassword(pass, hashe, salt);
		}

		private void Login(string uDuty) {
			Form form;
			Hide();

			//try{
				switch(uDuty) {
					case "Admin":
						form = new AdminForm();
						form.ShowDialog();
						_usersTable = _sysUsersTableAdapter.GetData();
						break;
					case "Boss":
						form = new BossForm();
						form.ShowDialog();
						break;
					case "Security":
						form = new SecurityForm();
						form.ShowDialog();
						break;
				}
			
			Show();
		}

		private void tB_password_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter)
				Btn_Enter_Click(null, null);
		}

		private void b_admin_Click(object sender, EventArgs e)
		{
			tB_username.Text = "Admin";
			tB_password.Text = "Admin";
		}

		private void b_security_Click(object sender, EventArgs e)
		{
			tB_username.Text = "Security";
			tB_password.Text = "Security";
		}

		private void b_boss_Click(object sender, EventArgs e)
		{
			tB_username.Text = "Boss";
			tB_password.Text = "Boss";
		}
	}
}
