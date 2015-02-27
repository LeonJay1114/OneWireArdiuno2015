using System;
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

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cb_ComPort.Items.Add(port);
            }
            gb_users.BringToFront();
            //// TODO: This line of code loads data into the 'aC_DataSet.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.aC_DataSet.Staff);
            //// TODO: This line of code loads data into the 'aC_DataSet.SystemUsers' table. You can move, or remove it, as needed.
            //this.systemUsersTableAdapter.Fill(this.aC_DataSet.SystemUsers);
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

	}
}
