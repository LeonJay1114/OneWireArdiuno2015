using System;
using System.Windows.Forms;

namespace SerialPortUsing {
	public partial class AdminForm : Form {
		public AdminForm() {
			InitializeComponent();
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
            if (панельНавигатораToolStripMenuItem.Checked = true)
            {
                treeView1.Width = 0;
            }
            if (панельНавигатораToolStripMenuItem.Checked)
            {
                treeView1.Width = 132;
            }
            
        }
	}
}
