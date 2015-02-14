using System;
using System.Linq;
using System.Windows.Forms;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;
using SerialPortUsing.Access_control_in_OneWireTableAdapters;

namespace SerialPortUsing {
	public partial class Authorisation : Form {

		// Компонент-драйвер базы Access: http://www.microsoft.com/en-us/download/confirmation.aspx?id=23734

		private Access_control_in_OneWire _base; // Экземпляр класса подключенного источника данных
		private SystemUsersTableAdapter _sysUsersTableAdapter; // Экземпляр класса адаптера одной из таблиц. (Лежит в SerialPortUsing.AC_DataSetTableAdapters)
		private const string LOGIN_PASS_FILTER = "login='{0}' AND password='{1}'"; // Выражение-фильтр синтаксиса "DataView RowFilter Syntax" http://www.csharp-examples.net/dataview-rowfilter/
		// TODO: Это всё хуйня, надо пилить красотищу про хэши и соли.

		public Authorisation() {
			InitializeComponent();

            _base = new Access_control_in_OneWire(); // Инициализируем адаптер базы
			_sysUsersTableAdapter = new SystemUsersTableAdapter(); // Инициализируем адаптер таблицы
			_sysUsersTableAdapter.ClearBeforeFill = true; // Говорим нашему адаптеру таблицы, чтобы очищал таблицу перед заполнением
			
			_sysUsersTableAdapter.Fill(_base.SystemUsers); // Дастаём таблицу из базы и кладём к в свой адаптер базы
		}

		#region TestDB connection
		private void Autorization_Load(object sender, EventArgs e) {
			try {
				if (_base.IsInitialized)
					CheckConnection.Text = "Connection OK!";
			}
			catch (Exception er) {
				MessageBox.Show(this, er.ToString(), "ЕГГОГ");
			}
		}
		#endregion

		private void Btn_Enter_Click(object sender, EventArgs e) {
			
			string uName = tB_username.Text;
			string uPass = tB_password.Text;


			System.Data.DataRow[] searchResult; // Массив строк, который получим от поиска по таблице
			searchResult = _base.SystemUsers.Select(String.Format(LOGIN_PASS_FILTER, uName, uPass)); // Выбор строк, удовлетворяющих условиям, заданным в строке-фильтре LOGIN_PASS_FILTER

			int count = searchResult.Count();

			if (count == 1) {
				MessageBox.Show("Логин и пароль верны.");
				if(searchResult[0][1].ToString() == "Admin")
					MessageBox.Show("Привет, Админ!" + searchResult[0][0]);
			}
			else if (count > 1) {
				MessageBox.Show("Дубликаты логина и пароля блядь.");//проверка БД на наличие у разных пользователей одинаковой пары логин пароль
			}
			else {
				MessageBox.Show("Введенная пара логин пароль отсутствует в базе данных. Обратитесь к системному администратору.");
			}
		}
	}
}
