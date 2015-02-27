using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortUsing {
	public partial class AdminForm : Form
	{

	    private const int NAVIGATION_TREE_WIDTH = 132;
	    private const int GROUP_BOXES_PADDING = 10;

		public AdminForm() {
			InitializeComponent();
		    groupBox2.Location = groupBox1.Location;
		    groupBox2.Size = groupBox1.Size;
            openFileDialog1.Filter = "accdb files (*.accdb)|*.accdb|All files (*.*)|*.*";//Маска OpenFileDialog
		}

		private void AdminForm_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "access_control_in_OneWire.SystemUsers". При необходимости она может быть перемещена или удалена.
            this.systemUsersTableAdapter.Fill(this.access_control_in_OneWire.SystemUsers);

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cb_ComPort.Items.Add(port);
            }
            groupBox2.BringToFront();
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
                treeView1.Width = NAVIGATION_TREE_WIDTH;
	        }
	        else
	        {
                treeView1.Width = 0;
	        }

            // TODO: do this for all groupboxes!
            groupBox1.Left = treeView1.Width + GROUP_BOXES_PADDING;

            // TODO: do this for all groupboxes!
            groupBox1.Width = this.Width - treeView1.Width - GROUP_BOXES_PADDING*2 - treeView1.Left;

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
            switch (treeView1.SelectedNode.Text){
                case "Настройки":

                    break;

            }
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

	}
}
