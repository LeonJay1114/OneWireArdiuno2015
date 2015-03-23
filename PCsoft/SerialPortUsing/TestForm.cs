using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

using System.Management; //Тулзы управления. Доступны после подключения ссылки на System.Management чрез *Проект->ПодключитьСсылку*.

using System.IO.Ports;

namespace SerialPortUsing {
	public partial class TestForm : Form {

		private static SerialPort port1;

		private static Encoding coder = Encoding.ASCII;

		private UIDCOMDialog _dialog;

		#region Structing
		public TestForm() {
			InitializeComponent();
			InitializePortObject();
			//port1.DataReceived += new SerialDataReceivedEventHandler(dataReceiver);
		}
		private void InitializePortObject() {
			port1 = new SerialPort();
			port1.Encoding = System.Text.Encoding.ASCII;
			port1.BaudRate = 9600;
			port1.Parity = Parity.None;
			port1.StopBits = StopBits.One;
			port1.DataBits = 8;
			port1.Handshake = Handshake.None;	
		}
		#endregion

		#region testing

			#region InformationGiving Buttons
			private void CB_displayCOMs_Click(object sender, EventArgs e) {
				try {
					ManagementObjectSearcher searcher =
						new ManagementObjectSearcher("root\\CIMV2",
						"SELECT * FROM Win32_SerialPort");

					foreach (ManagementObject queryObj in searcher.Get()) {
						lb_test.Items.Add("");
						lb_test.Items.Add("-----------------------------------");
						lb_test.Items.Add("Win32_SerialPort instance");
						lb_test.Items.Add("Availability: " + queryObj["Availability"]);
						lb_test.Items.Add("Caption: " + queryObj["Caption"]);
						lb_test.Items.Add("InstallDate: " + queryObj["InstallDate"]);


						if (queryObj["Capabilities"] == null)
							lb_test.Items.Add("Capabilities: " + queryObj["Capabilities"]);
						else {
							UInt16[] arrCapabilities = (UInt16[])(queryObj["Capabilities"]);
							foreach (UInt16 arrValue in arrCapabilities) {
								lb_test.Items.Add("Capabilities: " + arrValue.ToString());
							}
						}

					}

				}
				catch (ManagementException y) {
					MessageBox.Show("An error occurred while querying for WMI data: " + y.Message);
				}

				foreach (var port in SerialPort.GetPortNames()) {
					lb_test.Items.Add(port);
				}
			}

			private void CB_displayUSBs_Click(object sender, EventArgs e) {
				try {
					ManagementObjectSearcher searcher =
						new ManagementObjectSearcher("root\\CIMV2",
						"SELECT * FROM Win32_USBController");

					foreach (ManagementObject queryObj in searcher.Get()) {
						lb_test.Items.Add("-----------------------------------");
						lb_test.Items.Add("Win32_USBController instance");
						lb_test.Items.Add("Availability: " + queryObj["Availability"]);
						lb_test.Items.Add("Name: " + queryObj["Name"]);
						lb_test.Items.Add("Caption: " + queryObj["Caption"]);

					}
				}
				catch (ManagementException y) {
					lb_test.Items.Add("An error occurred while querying for WMI data: " + y.Message);
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


		private void dataReceiver(object sender, EventArgs e) {
			MessageBox.Show("");
		}

		private void CB_openPort_Click(object sender, EventArgs e) {
			if (port1.IsOpen) port1.Close();
			port1.PortName = tB_PortToOpen.Text;
			port1.Open();
		}

		private void CB_writeToPort_Click(object sender, EventArgs e){
			//byte[] t = BitConverter.GetBytes(Convert.ToInt16(tB_toWriteToPort.Text));
			//port1.Write(t,0,2);
			port1.Write(tB_toWriteToPort.Text);
			char[] end = new[] {'\n'};
			port1.Write(end,0,1);
		}

		private void CB_readFromPort_Click(object sender, EventArgs e)
		{

			int count;
			if (chB_readAll.Checked){
				count = port1.BytesToRead;
			}
			else{
				count = (int)nUD_bytesToRead.Value;
			}

			byte[] buf = new byte[count];
			port1.BaseStream.Read(buf, 0, count);

			//foreach (var b in buf) {
			//	tB_gotFromPort.Text += (int)b + ";";
			//}
			tB_gotFromPort.Text += coder.GetString(buf);
		}


		private void CB_closePort_Click(object sender, EventArgs e) {
			if (port1.IsOpen) port1.Close();
		}

		private void lb_test_DoubleClick(object sender, EventArgs e) {
			lb_test.Items.Clear();
		}

		private void chB_readdAll_CheckedChanged(object sender, EventArgs e){
			nUD_bytesToRead.Enabled = !chB_readAll.Checked;
		}
		#endregion

		#region uid listening
		private void cB_listen_Click(object sender, EventArgs e) {
			if(_dialog != null && _dialog.IsOpen())
				_dialog.Close();
			_dialog = new UIDCOMDialog(coB_coms.Text, 9600, 8, OnUIDReceived);
		}

		private void OnUIDReceived(object sender, string uid, bool enterExit) {
			string uidstr = BitConverter.ToString(Convert.FromBase64String(uid));
			OutputToUIDOutput(uid + Environment.NewLine + uidstr + Environment.NewLine+Environment.NewLine);
		}

		delegate void OutputToUIDOutputCallback(string text);
		void OutputToUIDOutput(string text) {
			if(tb_uidOutput.InvokeRequired) {
				OutputToUIDOutputCallback cb = new OutputToUIDOutputCallback(OutputToUIDOutput);
				this.Invoke(cb, new object[]{text});
			}
			else {
				tb_uidOutput.Text+=text;
			}

		}

		private void tb_uidOutput_MouseDoubleClick(object sender, MouseEventArgs e) {
			tb_uidOutput.Text = "";
		}
		#endregion

		#region tabsSwitching
		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			if (port1 != null && port1.IsOpen) {
				if(CheckPortExistance(port1.PortName))
					port1.Close();
				else
					InitializePortObject();
			}

			if (tabControl1.SelectedIndex == 1) {
				coB_coms.Items.Clear();
				var ports = SerialPort.GetPortNames();
				if (ports.Length > 0)
					coB_coms.Items.AddRange(ports);
			}
		}

		private bool CheckPortExistance(string portName) {
			try {
				ManagementObjectSearcher searcher =
					new ManagementObjectSearcher("root\\CIMV2",
					"SELECT * FROM Win32_SerialPort");

				foreach (ManagementObject queryObj in searcher.Get()) {
					lb_test.Items.Add("");
					lb_test.Items.Add("-----------------------------------");
					lb_test.Items.Add("Win32_SerialPort instance");
					lb_test.Items.Add("Availability: " + queryObj["Availability"]);
					lb_test.Items.Add("Caption: " + queryObj["Caption"]);
					lb_test.Items.Add("InstallDate: " + queryObj["InstallDate"]);


					if (queryObj["Capabilities"] == null)
						lb_test.Items.Add("Capabilities: " + queryObj["Capabilities"]);
					else {
						UInt16[] arrCapabilities = (UInt16[])(queryObj["Capabilities"]);
						foreach (UInt16 arrValue in arrCapabilities) {
							lb_test.Items.Add("Capabilities: " + arrValue.ToString());
						}
					}

				}

			}
			catch (ManagementException y) {
				//MessageBox.Show("An error occurred while querying for WMI data: " + e.Message);
			}
			return false;
		}
		#endregion

		private void button1_Click(object sender, EventArgs e) {
			Authorisation newForm = new Authorisation();
			newForm.Show();
		}
	}
}
