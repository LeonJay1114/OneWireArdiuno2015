using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortUsing
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cb_ComPort.Items.Add(port);
            }
        }

        private void tb_dbpath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_dbpath.Text = openFileDialog1.FileName;
        }

        private void b_saveConfig_Click(object sender, EventArgs e)
        {

        }
    }
}
