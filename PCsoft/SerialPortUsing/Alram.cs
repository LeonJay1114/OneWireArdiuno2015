using System.Windows.Forms;

namespace SerialPortUsing
{
	public partial class Alarm : Form
	{
		public Alarm(string uid)
		{
			InitializeComponent();
			label1.Text = "Предъявлен неизвестный UID!\n" + uid;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		
	}
}
