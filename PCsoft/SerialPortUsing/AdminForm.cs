using System;
using System.Data;
using System.Data.OleDb;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortUsing {
	public partial class AdminForm : Form
	{
	    private const int GROUP_BOXES_PADDING = 10;
		private const int GROUP_BOXES_TOP = 21;

		public AdminForm() {
			InitializeComponent();
		    gb_users.Location = gb_sys.Location;
		    gb_users.Size = gb_sys.Size;
            openFileDialog1.Filter = "accdb files (*.accdb)|*.accdb|All files (*.*)|*.*";//Маска OpenFileDialog
			
			
			MakeGroupBoxesUp();
		}

		private void MakeGroupBoxesUp() {
			gb_staff.Left = gb_sys.Left = gb_users.Left = tv_navigation.Width + GROUP_BOXES_PADDING + tv_navigation.Left;
			gb_staff.Top = gb_sys.Top = gb_users.Top = GROUP_BOXES_TOP;
			gb_staff.Width = gb_sys.Width = gb_users.Width = this.Width - gb_staff.Left - GROUP_BOXES_PADDING*2;
			gb_staff.Height = gb_sys.Height = gb_users.Height = this.Height - 72;
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'access_control_in_OneWire.Staff' table. You can move, or remove it, as needed.
			this.staffTableAdapter.Fill(this.access_control_in_OneWire.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "access_control_in_OneWire.SystemUsers". При необходимости она может быть перемещена или удалена.
            this.systemUsersTableAdapter.Fill(this.access_control_in_OneWire.SystemUsers);
			

			InitializeQueries();

			foreach (string port in SerialPort.GetPortNames()){
                cb_ComPort.Items.Add(port);
            }
            gb_users.BringToFront();
		}

		private void InitializeQueries()
		{
			systemUsersTableAdapter.Adapter.DeleteCommand = new OleDbCommand("Delete * from SystemUsers where Uid = par0", systemUsersTableAdapter.Connection);
			systemUsersTableAdapter.Adapter.UpdateCommand = new OleDbCommand("UPDATE SystemUsers SET SystemUsers.Uid = newuid, SystemUsers.userType = utype, SystemUsers.login = log, SystemUsers.password = pass WHERE SystemUsers.Uid = olduid", systemUsersTableAdapter.Connection); // Don't delete table names or it'll crash.
		}

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void панельНавигатораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchNavigationPanel(панельНавигатораToolStripMenuItem.Checked);
        }

	    private void switchNavigationPanel(bool open)
	    {
	        if (open)
	        {
                tv_navigation.Width = tv_navigation.Width;
	        }
	        else
	        {
                tv_navigation.Width = 0;
	        }

            // TODO: do this for all groupboxes!
            gb_sys.Left = tv_navigation.Width + GROUP_BOXES_PADDING;

            // TODO: do this for all groupboxes!
            gb_sys.Width = this.Width - tv_navigation.Width - GROUP_BOXES_PADDING*2 - tv_navigation.Left;

	    }

        private void b_saveConfig_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_dbpath.Text = openFileDialog1.FileName;
        }



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (tv_navigation.SelectedNode.Text){
                case "Настройки":
					gb_sys.BringToFront();
                    break;
				case "Пользователи":
					gb_users.BringToFront();
					break;
				case "Сотрудники":
					gb_staff.BringToFront();
					break;
            }
            //MessageBox.Show(tv_navigation.SelectedNode.Text);
        }

        private void b_addUser_Click(object sender, EventArgs e)
        {
			if (string.IsNullOrEmpty(tB_UID.Text) || string.IsNullOrEmpty(cB_userType.Text) 
			|| string.IsNullOrEmpty(tB_login.Text) || string.IsNullOrEmpty(tB_password.Text))
			{
				MessageBox.Show("Лох, пидр, нет друзей!!!");
				return;
			}
	        systemUsersTableAdapter.Insert(tB_UID.Text, cB_userType.Text, tB_login.Text, tB_password.Text);
			this.systemUsersTableAdapter.Fill(this.access_control_in_OneWire.SystemUsers);
	        //dgv_users.Rows.Add(tB_UID.Text, cB_userType.Text, tB_login.Text, tB_password.Text);
        }

		private void b_delUser_Click(object sender, EventArgs e)
		{

			var rez = MessageBox.Show(this, "Вы действительно хотите удалить " + dgv_users.SelectedRows.Count +" записей?", "Подтверждение", MessageBoxButtons.OKCancel);
			if(rez==DialogResult.Cancel)return;

			systemUsersTableAdapter.Adapter.DeleteCommand.Connection.Open();
			foreach (DataGridViewRow r in dgv_users.SelectedRows)
			{
				string test = r.Cells[0].Value.ToString();
				systemUsersTableAdapter.Adapter.DeleteCommand.Parameters.Add(new OleDbParameter("par0", test));
				systemUsersTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
				systemUsersTableAdapter.Adapter.DeleteCommand.Parameters.Clear();
			}
			systemUsersTableAdapter.Adapter.DeleteCommand.Connection.Close();
			this.systemUsersTableAdapter.Fill(this.access_control_in_OneWire.SystemUsers);
		}



		private void dgv_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
			tB_UID.Text = dgv_users.SelectedRows[0].Cells[0].Value.ToString(); 
			cB_userType.Text = dgv_users.SelectedRows[0].Cells[1].Value.ToString();
			tB_login.Text = dgv_users.SelectedRows[0].Cells[2].Value.ToString();
			tB_password.Text = dgv_users.SelectedRows[0].Cells[3].Value.ToString();
		}

		private void b_editUser_Click(object sender, EventArgs e)
		{
			if (dgv_users.SelectedRows.Count == 0 || dgv_users.SelectedRows.Count > 1){
				MessageBox.Show(this, "Должна быть выделена одна строка.", "Некорректное выделение");
				return;
			}
			systemUsersTableAdapter.Adapter.UpdateCommand.Connection.Open();
			systemUsersTableAdapter.Adapter.UpdateCommand.Parameters.Add(new OleDbParameter("newuid", tB_UID.Text));
			systemUsersTableAdapter.Adapter.UpdateCommand.Parameters.Add(new OleDbParameter("utype", cB_userType.Text));
			systemUsersTableAdapter.Adapter.UpdateCommand.Parameters.Add(new OleDbParameter("log", tB_login.Text));
			systemUsersTableAdapter.Adapter.UpdateCommand.Parameters.Add(new OleDbParameter("pass", tB_password.Text));
			systemUsersTableAdapter.Adapter.UpdateCommand.Parameters.Add(new OleDbParameter("olduid", dgv_users.SelectedRows[0].Cells[0].Value.ToString()));
			systemUsersTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
			systemUsersTableAdapter.Adapter.UpdateCommand.Parameters.Clear();
			systemUsersTableAdapter.Adapter.DeleteCommand.Connection.Close();

			this.systemUsersTableAdapter.Fill(this.access_control_in_OneWire.SystemUsers);
		}
	}
}
