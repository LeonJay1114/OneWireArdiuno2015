using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortUsing {
	public delegate void UIDReceivingHandler(object sender, string uid);
	class UIDCOMListener {
		#region serving objects
		private readonly SerialPort _port;
		#endregion

		#region parameters
		private readonly int _uidLength;
		private int _accumulatedBytesCount= 0;
		private readonly byte[] _accumulatedBytes;
		private bool _paused = false;
		#endregion

		#region events
		event UIDReceivingHandler OnUIDReceived;
		#endregion

		#region Structing
		public UIDCOMListener(string portName, int baudRate, int uIDLength, UIDReceivingHandler receivingHandler) {
			_port = new SerialPort(portName, baudRate);
			_port.Parity = Parity.None;
			_port.StopBits = StopBits.One;
			_port.DataBits = 8;
			_port.Handshake = Handshake.None;

			_uidLength = uIDLength;
			_accumulatedBytes = new byte[_uidLength];

			OnUIDReceived += receivingHandler;

			try {
				_port.Open();
			}
			catch(Exception) {
				MessageBox.Show(null, "Не удалось получить доступ к COM-порту.", "Ошибка");
				throw;
			}

			_port.DataReceived += port_DataReceived;
		}
		#endregion

		#region Handling data reception
		private void AccumulateUID(byte[] bytes) {
			foreach(byte b in bytes) {
				_accumulatedBytes[_accumulatedBytesCount] = b;
				_accumulatedBytesCount++;
				if(_accumulatedBytesCount==_uidLength) {
					_accumulatedBytesCount = 0;
					OnUIDReceived(this, Convert.ToBase64String(_accumulatedBytes));
				}
			}
		}

		private void port_DataReceived(object sender, SerialDataReceivedEventArgs e){
 			byte[] bytes = new byte[_port.BytesToRead];
			_port.Read(bytes, 0, _port.BytesToRead);

			if(!_paused)
				AccumulateUID(bytes);
		}
		#endregion

		#region gettings
		public bool IsOpen() {
			if(_port!=null && _port.IsOpen)
				return true;
			return false;
		}
		public bool IsPaused() {
			return _paused;
		}
		#endregion

		#region Commands
		public void Close() {
			if(_port.IsOpen && CheckPortExistance(_port.PortName))
				_port.Close();
				_port.Dispose();
		}

		public void Pause() {
			_paused = true;
		}
		public void Resume() {
			_paused = false;
		}
		#endregion

		#region Helping functions
		private bool CheckPortExistance(string portName) {
			foreach(string port in SerialPort.GetPortNames()) {
				if(port == portName) return true;
			}
			return false;
		}
		#endregion

	}
}
