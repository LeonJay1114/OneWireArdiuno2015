using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialPortUsing {
	public partial class BossForm : Form {
		public BossForm() {
			InitializeComponent();
		}

		private void b_setPeriod_Click(object sender, EventArgs e)
		{
			DateTime today = DateTime.Now;
			today = today.AddHours(-today.Hour);
			today = today.AddMinutes(-today.Minute);
			today = today.AddSeconds(-today.Second);
			switch (((Button)sender).Text)
			{
				case "Последние сутки":
					joinedEventLogAdapter.FillByPeriod(access_control_in_OneWire.JoinedEventLog, today.AddDays(-1), today);
					break;
				case "Последняя неделя":
					joinedEventLogAdapter.FillByPeriod(access_control_in_OneWire.JoinedEventLog, today.AddDays(-7), today);
					break;
				case "Последние 10 дней":
					joinedEventLogAdapter.FillByPeriod(access_control_in_OneWire.JoinedEventLog, today.AddDays(-10), today);
					break;
				case "С начала месяца":
					joinedEventLogAdapter.FillByPeriod(access_control_in_OneWire.JoinedEventLog, today.AddDays(-today.Day), today);
					break;
				case "Прошлый месяц":
					joinedEventLogAdapter.FillByPeriod(access_control_in_OneWire.JoinedEventLog, today.AddDays(-today.Day).AddMonths(-1), today.AddDays(-today.Day));
					break;
				case "Показать данные за промежуток"://dateTimePicker1.Value.ToString("yy-MM-dd")
					joinedEventLogAdapter.FillByPeriod(access_control_in_OneWire.JoinedEventLog, dateTimePicker2.Value, dateTimePicker3.Value);
					break;
			}
		}

		private void BossForm_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "access_control_in_OneWire.JoinedEventLog". При необходимости она может быть перемещена или удалена.
			this.joinedEventLogAdapter.Fill(this.access_control_in_OneWire.JoinedEventLog);

		}
	}
}
