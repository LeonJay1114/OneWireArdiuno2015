using System;
using System.Collections.Generic;
using System.Text;

using System.IO.Ports;

namespace SerialPortUsing {
	public delegate void UIDReceivingHandler(object sender, string uid);
	class UIDCOMListener {
		private readonly SerialPort _port;

		private readonly int _uidLength;
		private int _accumulatedBytesCount= 0;
		private readonly byte[] _accumulatedBytes;

		event UIDReceivingHandler OnUIDReceived;

		public UIDCOMListener(string portName, int baudRate, int uIDLength, UIDReceivingHandler receivingHandler) {
			_port = new SerialPort(portName, baudRate);
			_port.Parity = Parity.None;
			_port.StopBits = StopBits.One;
			_port.DataBits = 8;
			_port.Handshake = Handshake.None;

			_uidLength = uIDLength;
			_accumulatedBytes = new byte[_uidLength];

			OnUIDReceived += receivingHandler;

			_port.Open();
			_port.DataReceived += port_DataReceived;
		}

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

			AccumulateUID(bytes);
		}

		public bool IsOpen() {
			if(_port!=null && _port.IsOpen)
				return true;
			return false;
		}
		public void Close() {
			if(_port.IsOpen && CheckPortExistance(_port.PortName))
				_port.Close();
				_port.Dispose();
		}
		private bool CheckPortExistance(string portName) {
			foreach(string port in SerialPort.GetPortNames()) {
				if(port == portName) return true;
			}
			return false;
		}

	}
}
