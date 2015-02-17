using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialPortUsing {
	public partial class SecurityForm : Form {
		public SecurityForm() {
			InitializeComponent();
		}

		public void ShowFace(string picturePath, string fio, int ttl) {
			pic_face.Image = new Bitmap(picturePath);
			l_fio.Text = fio;
			
			this.Show();
			this.TopMost = true;
			this.CenterToScreen();

			Timer tmr = new Timer {Interval = ttl};
			tmr.Start();
			tmr.Tick += tmr_Tick;
		}
		private void tmr_Tick(object sender, EventArgs e) {
			this.HideFace();
		}
		public void HideFace() {
			this.Hide();
		}

		private void cB_testButton_Click(object sender, EventArgs e) {
			
		}
	}
}

//
// "Дэн Дэн\nДэн Денис!"