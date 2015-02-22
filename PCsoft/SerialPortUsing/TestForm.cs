using System;
using System.Text;
using System.Windows.Forms;

using System.Management; //Тулзы управления. Доступны после подключения ссылки на System.Management чрез *Проект->ПодключитьСсылку*.

using System.IO.Ports;

namespace SerialPortUsing
{
	public partial class TestForm : Form
	{
		
		private static SerialPort port1;

		private static Encoding coder = Encoding.ASCII;

		public TestForm()
		{
			InitializeComponent();

			port1 = new SerialPort();
			port1.Encoding = System.Text.Encoding.ASCII;
			port1.BaudRate = 9600;
			port1.Parity = Parity.None;
			port1.StopBits = StopBits.One;
			port1.DataBits = 8;
			port1.Handshake = Handshake.None;

			//port1.DataReceived += new SerialDataReceivedEventHandler(dataReceiver);
		}

	#region InformationGiving Buttons
		private void CB_displayCOMs_Click(object sender, EventArgs e)
		{
			try
			{
				ManagementObjectSearcher searcher =
				    new ManagementObjectSearcher("root\\CIMV2",
					"SELECT COUNT(DeviceID) FROM Win32_SerialPort");

				foreach (ManagementObject queryObj in searcher.Get())
				{
					listBox1.Items.Add("");
					listBox1.Items.Add("-----------------------------------");
					listBox1.Items.Add("Win32_SerialPort instance");
					listBox1.Items.Add("Availability: " + queryObj["Availability"]);
					listBox1.Items.Add("Caption: " + queryObj["Caption"]);
					listBox1.Items.Add("InstallDate: " + queryObj["InstallDate"]);
					 

					if (queryObj["Capabilities"] == null)
						listBox1.Items.Add("Capabilities: " + queryObj["Capabilities"]);
					else
					{
						UInt16[] arrCapabilities = (UInt16[])(queryObj["Capabilities"]);
						foreach (UInt16 arrValue in arrCapabilities)
						{
							listBox1.Items.Add("Capabilities: " + arrValue.ToString());
						}
					}

				}

			}
			catch (ManagementException y)
			{
				//MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
			}
		}

		private void CB_displayUSBs_Click(object sender, EventArgs e)
		{
			try
			{
				ManagementObjectSearcher searcher =
				    new ManagementObjectSearcher("root\\CIMV2",
				    "SELECT * FROM Win32_USBController");

				foreach (ManagementObject queryObj in searcher.Get())
				{
					listBox1.Items.Add("-----------------------------------");
					listBox1.Items.Add("Win32_USBController instance");
					listBox1.Items.Add("Availability: " + queryObj["Availability"]);
					listBox1.Items.Add("Name: " + queryObj["Name"]);
					listBox1.Items.Add("Caption: " + queryObj["Caption"]);

				}
			}
			catch (ManagementException y)
			{
				listBox1.Items.Add("An error occurred while querying for WMI data: " + y.Message);
			}
		}

		/*private String GetCOMNames() {
			List<String> rez = new List<string>();

			ManagementObjectSearcher searcher =
					new ManagementObjectSearcher("root\\CIMV2",
					"SELECT * FROM Win32_USBController");

			foreach (var queryObj in searcher.Get()) {
				rez.Add((string)queryObj["DeviceID"]);
			}
		}*/
        

	#endregion

		
		private void dataReceiver(object sender, EventArgs e){
			MessageBox.Show("");
		}
		
		private void CB_openPort_Click(object sender, EventArgs e){
			if(port1.IsOpen) port1.Close();
			port1.PortName = tB_PortToOpen.Text;
			port1.Open();
		}

		private void CB_writeToPort_Click(object sender, EventArgs e){
			port1.Write(tB_toWriteToPort.Text);
		}

		private void CB_readFromPort_Click(object sender, EventArgs e){
			int count = (int)nUD_bytesToRead.Value;
			byte[] buf = new byte[count];

			port1.BaseStream.Read(buf,0,count);

			foreach (var b in buf) {
				tB_gotFromPort.Text += b.ToString() + ";";
			}
			//tB_gotFromPort.Text += coder.GetString(buf);
		}
		
		private void CB_closePort_Click(object sender, EventArgs e){
			if(port1.IsOpen)port1.Close();
		}

		private void listBox1_DoubleClick(object sender, EventArgs e) {
			listBox1.Items.Clear();
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			if(port1.IsOpen && CheckPortExistance(port1.PortName))
			port1 = null;
		}

		private bool CheckPortExistance(string portName) {
			try {
				ManagementObjectSearcher searcher =
					new ManagementObjectSearcher("root\\CIMV2",
					"SELECT * FROM Win32_SerialPort");

				foreach (ManagementObject queryObj in searcher.Get()) {
					listBox1.Items.Add("");
					listBox1.Items.Add("-----------------------------------");
					listBox1.Items.Add("Win32_SerialPort instance");
					listBox1.Items.Add("Availability: " + queryObj["Availability"]);
					listBox1.Items.Add("Caption: " + queryObj["Caption"]);
					listBox1.Items.Add("InstallDate: " + queryObj["InstallDate"]);


					if (queryObj["Capabilities"] == null)
						listBox1.Items.Add("Capabilities: " + queryObj["Capabilities"]);
					else {
						UInt16[] arrCapabilities = (UInt16[])(queryObj["Capabilities"]);
						foreach (UInt16 arrValue in arrCapabilities) {
							listBox1.Items.Add("Capabilities: " + arrValue.ToString());
						}
					}

				}

			}
			catch (ManagementException y) {
				//MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
			}
			return false;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Authorisation newForm = new Authorisation();
            newForm.Show();
        }



	}
}
