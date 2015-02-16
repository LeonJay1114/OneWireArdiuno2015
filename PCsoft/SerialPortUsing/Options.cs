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

            Console.WriteLine("The following serial ports were found:");
            Console.WriteLine(ports.Length);
            foreach (string port in ports)
            {
                Console.WriteLine(port);
            }
        }
    }
}
