using System;
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
		}

		private void AdminForm_Load(object sender, EventArgs e) {
			// TODO: This line of code loads data into the 'aC_DataSet.Staff' table. You can move, or remove it, as needed.
			this.staffTableAdapter.Fill(this.aC_DataSet.Staff);
			// TODO: This line of code loads data into the 'aC_DataSet.SystemUsers' table. You can move, or remove it, as needed.
			this.systemUsersTableAdapter.Fill(this.aC_DataSet.SystemUsers);
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
	}
}
