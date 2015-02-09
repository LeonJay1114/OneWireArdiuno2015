using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SerialPortUsing
{
    public partial class Autorization : Form
    {
        //Не удаляй, http://www.microsoft.com/en-us/download/confirmation.aspx?id=23734 без этой х***и у меня остутствовал поставщик 
        //OLE DB microsoft office 12.0 access database engine
        private OleDbConnection DBCon = new OleDbConnection();//Создал коннект DBCon приватный для формы Autorization

        public Autorization()
        {
            InitializeComponent();
            DBCon.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Access_control\Access_control.accdb;
            Persist Security Info=False;"; //Теперь ниже можно DBCon.Open(); и DBCon.Close();
        }

        #region TestDB connection 
        private void Autorization_Load(object sender, EventArgs e)
        {
            try
            {
                DBCon.Open();
                CheckConnection.Text = "Connection OK!";
                DBCon.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error "+ er);
            }
        }
        #endregion

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            DBCon.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = DBCon;
            command.CommandText = "select * from System_users where login='" + TB_Username.Text + "' and password='" + TB_password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count ++;
            }
            if (count == 1)
            {
                MessageBox.Show("Логин и пароль верны."+count);

            }
            else if (count > 1)
            {
                MessageBox.Show("Дубликаты логина и пароля блядь.");//проверка БД на наличие у разных пользователей одинаковой пары логин пароль
            }
            else
            {
                MessageBox.Show("Введенная пара логин пароль отсутствует в базе данных. Обратитесь к системному администратору.");
            }
            DBCon.Close();
        }
       // private void Autorization
    }
}
