namespace SerialPortUsing {
	partial class BossForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.gB_event = new System.Windows.Forms.GroupBox();
			this.gB_period = new System.Windows.Forms.GroupBox();
			this.b_setPeriod_PastMonth = new System.Windows.Forms.Button();
			this.b_setPeriod_ThisMonth = new System.Windows.Forms.Button();
			this.b_setPeriod_Last10Days = new System.Windows.Forms.Button();
			this.b_setPeriod_PastWeek = new System.Windows.Forms.Button();
			this.b_setPeriod_PastDay = new System.Windows.Forms.Button();
			this.b_showEvent = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.dgv_event = new System.Windows.Forms.DataGridView();
			this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enterTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.графикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.подразделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.joinedEventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.access_control_in_OneWire = new SerialPortUsing.Access_control_in_OneWire();
			this.joinedEventLogAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.JoinedEventLogAdapter();
			this.gB_event.SuspendLayout();
			this.gB_period.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_event)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.joinedEventLogBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.access_control_in_OneWire)).BeginInit();
			this.SuspendLayout();
			// 
			// gB_event
			// 
			this.gB_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gB_event.Controls.Add(this.gB_period);
			this.gB_event.Controls.Add(this.dgv_event);
			this.gB_event.Location = new System.Drawing.Point(12, 12);
			this.gB_event.Name = "gB_event";
			this.gB_event.Size = new System.Drawing.Size(1047, 506);
			this.gB_event.TabIndex = 6;
			this.gB_event.TabStop = false;
			this.gB_event.Text = "gb_event";
			// 
			// gB_period
			// 
			this.gB_period.Controls.Add(this.b_setPeriod_PastMonth);
			this.gB_period.Controls.Add(this.b_setPeriod_ThisMonth);
			this.gB_period.Controls.Add(this.b_setPeriod_Last10Days);
			this.gB_period.Controls.Add(this.b_setPeriod_PastWeek);
			this.gB_period.Controls.Add(this.b_setPeriod_PastDay);
			this.gB_period.Controls.Add(this.b_showEvent);
			this.gB_period.Controls.Add(this.dateTimePicker2);
			this.gB_period.Controls.Add(this.label18);
			this.gB_period.Controls.Add(this.label19);
			this.gB_period.Controls.Add(this.dateTimePicker3);
			this.gB_period.Location = new System.Drawing.Point(852, 19);
			this.gB_period.Name = "gB_period";
			this.gB_period.Size = new System.Drawing.Size(189, 328);
			this.gB_period.TabIndex = 1;
			this.gB_period.TabStop = false;
			this.gB_period.Text = "gB_period";
			// 
			// b_setPeriod_PastMonth
			// 
			this.b_setPeriod_PastMonth.Location = new System.Drawing.Point(13, 135);
			this.b_setPeriod_PastMonth.Name = "b_setPeriod_PastMonth";
			this.b_setPeriod_PastMonth.Size = new System.Drawing.Size(170, 23);
			this.b_setPeriod_PastMonth.TabIndex = 17;
			this.b_setPeriod_PastMonth.Text = "Прошлый месяц";
			this.b_setPeriod_PastMonth.UseVisualStyleBackColor = true;
			this.b_setPeriod_PastMonth.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// b_setPeriod_ThisMonth
			// 
			this.b_setPeriod_ThisMonth.Location = new System.Drawing.Point(14, 106);
			this.b_setPeriod_ThisMonth.Name = "b_setPeriod_ThisMonth";
			this.b_setPeriod_ThisMonth.Size = new System.Drawing.Size(170, 23);
			this.b_setPeriod_ThisMonth.TabIndex = 16;
			this.b_setPeriod_ThisMonth.Text = "С начала месяца";
			this.b_setPeriod_ThisMonth.UseVisualStyleBackColor = true;
			this.b_setPeriod_ThisMonth.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// b_setPeriod_Last10Days
			// 
			this.b_setPeriod_Last10Days.Location = new System.Drawing.Point(13, 77);
			this.b_setPeriod_Last10Days.Name = "b_setPeriod_Last10Days";
			this.b_setPeriod_Last10Days.Size = new System.Drawing.Size(170, 23);
			this.b_setPeriod_Last10Days.TabIndex = 15;
			this.b_setPeriod_Last10Days.Text = "Последние 10 дней";
			this.b_setPeriod_Last10Days.UseVisualStyleBackColor = true;
			this.b_setPeriod_Last10Days.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// b_setPeriod_PastWeek
			// 
			this.b_setPeriod_PastWeek.Location = new System.Drawing.Point(13, 48);
			this.b_setPeriod_PastWeek.Name = "b_setPeriod_PastWeek";
			this.b_setPeriod_PastWeek.Size = new System.Drawing.Size(170, 23);
			this.b_setPeriod_PastWeek.TabIndex = 14;
			this.b_setPeriod_PastWeek.Text = "Последняя неделя";
			this.b_setPeriod_PastWeek.UseVisualStyleBackColor = true;
			this.b_setPeriod_PastWeek.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// b_setPeriod_PastDay
			// 
			this.b_setPeriod_PastDay.Location = new System.Drawing.Point(13, 19);
			this.b_setPeriod_PastDay.Name = "b_setPeriod_PastDay";
			this.b_setPeriod_PastDay.Size = new System.Drawing.Size(170, 23);
			this.b_setPeriod_PastDay.TabIndex = 13;
			this.b_setPeriod_PastDay.Text = "Последние сутки";
			this.b_setPeriod_PastDay.UseVisualStyleBackColor = true;
			this.b_setPeriod_PastDay.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// b_showEvent
			// 
			this.b_showEvent.Location = new System.Drawing.Point(14, 238);
			this.b_showEvent.Name = "b_showEvent";
			this.b_showEvent.Size = new System.Drawing.Size(169, 35);
			this.b_showEvent.TabIndex = 12;
			this.b_showEvent.Text = "Показать данные за промежуток";
			this.b_showEvent.UseVisualStyleBackColor = true;
			this.b_showEvent.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(44, 276);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(26, 276);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(13, 13);
			this.label18.TabIndex = 2;
			this.label18.Text = "с";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(20, 302);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(19, 13);
			this.label19.TabIndex = 3;
			this.label19.Text = "по";
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker3.Location = new System.Drawing.Point(44, 302);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(140, 20);
			this.dateTimePicker3.TabIndex = 5;
			// 
			// dgv_event
			// 
			this.dgv_event.AllowUserToAddRows = false;
			this.dgv_event.AllowUserToDeleteRows = false;
			this.dgv_event.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgv_event.AutoGenerateColumns = false;
			this.dgv_event.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_event.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сотрудникDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn,
            this.enterTimeDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn,
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.графикDataGridViewTextBoxColumn,
            this.подразделениеDataGridViewTextBoxColumn,
            this.типUIDDataGridViewTextBoxColumn});
			this.dgv_event.DataSource = this.joinedEventLogBindingSource;
			this.dgv_event.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgv_event.Location = new System.Drawing.Point(6, 19);
			this.dgv_event.Name = "dgv_event";
			this.dgv_event.ReadOnly = true;
			this.dgv_event.Size = new System.Drawing.Size(840, 481);
			this.dgv_event.TabIndex = 0;
			// 
			// сотрудникDataGridViewTextBoxColumn
			// 
			this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
			this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
			this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
			this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// должностьDataGridViewTextBoxColumn
			// 
			this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
			this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
			this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// uIDDataGridViewTextBoxColumn
			// 
			this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
			this.uIDDataGridViewTextBoxColumn.HeaderText = "UID";
			this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
			this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// фотоDataGridViewTextBoxColumn
			// 
			this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
			this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
			this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
			this.фотоDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enterTimeDataGridViewTextBoxColumn
			// 
			this.enterTimeDataGridViewTextBoxColumn.DataPropertyName = "EnterTime";
			this.enterTimeDataGridViewTextBoxColumn.HeaderText = "EnterTime";
			this.enterTimeDataGridViewTextBoxColumn.Name = "enterTimeDataGridViewTextBoxColumn";
			this.enterTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// exitTimeDataGridViewTextBoxColumn
			// 
			this.exitTimeDataGridViewTextBoxColumn.DataPropertyName = "ExitTime";
			this.exitTimeDataGridViewTextBoxColumn.HeaderText = "ExitTime";
			this.exitTimeDataGridViewTextBoxColumn.Name = "exitTimeDataGridViewTextBoxColumn";
			this.exitTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// табельныйНомерDataGridViewTextBoxColumn
			// 
			this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
			this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
			this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
			this.табельныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// номерПаспортаDataGridViewTextBoxColumn
			// 
			this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
			this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
			this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
			this.номерПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// графикDataGridViewTextBoxColumn
			// 
			this.графикDataGridViewTextBoxColumn.DataPropertyName = "График";
			this.графикDataGridViewTextBoxColumn.HeaderText = "График";
			this.графикDataGridViewTextBoxColumn.Name = "графикDataGridViewTextBoxColumn";
			this.графикDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// подразделениеDataGridViewTextBoxColumn
			// 
			this.подразделениеDataGridViewTextBoxColumn.DataPropertyName = "Подразделение";
			this.подразделениеDataGridViewTextBoxColumn.HeaderText = "Подразделение";
			this.подразделениеDataGridViewTextBoxColumn.Name = "подразделениеDataGridViewTextBoxColumn";
			this.подразделениеDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// типUIDDataGridViewTextBoxColumn
			// 
			this.типUIDDataGridViewTextBoxColumn.DataPropertyName = "Тип UID";
			this.типUIDDataGridViewTextBoxColumn.HeaderText = "Тип UID";
			this.типUIDDataGridViewTextBoxColumn.Name = "типUIDDataGridViewTextBoxColumn";
			this.типUIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// joinedEventLogBindingSource
			// 
			this.joinedEventLogBindingSource.DataMember = "JoinedEventLog";
			this.joinedEventLogBindingSource.DataSource = this.access_control_in_OneWire;
			// 
			// access_control_in_OneWire
			// 
			this.access_control_in_OneWire.DataSetName = "Access_control_in_OneWire";
			this.access_control_in_OneWire.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// joinedEventLogAdapter
			// 
			this.joinedEventLogAdapter.ClearBeforeFill = true;
			// 
			// BossForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1071, 530);
			this.Controls.Add(this.gB_event);
			this.Name = "BossForm";
			this.Text = "BossForm";
			this.Load += new System.EventHandler(this.BossForm_Load);
			this.gB_event.ResumeLayout(false);
			this.gB_period.ResumeLayout(false);
			this.gB_period.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_event)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.joinedEventLogBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.access_control_in_OneWire)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gB_event;
		private System.Windows.Forms.GroupBox gB_period;
		private System.Windows.Forms.Button b_setPeriod_PastMonth;
		private System.Windows.Forms.Button b_setPeriod_ThisMonth;
		private System.Windows.Forms.Button b_setPeriod_Last10Days;
		private System.Windows.Forms.Button b_setPeriod_PastWeek;
		private System.Windows.Forms.Button b_setPeriod_PastDay;
		private System.Windows.Forms.Button b_showEvent;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.DataGridView dgv_event;
		private Access_control_in_OneWire access_control_in_OneWire;
		private System.Windows.Forms.BindingSource joinedEventLogBindingSource;
		private Access_control_in_OneWireTableAdapters.JoinedEventLogAdapter joinedEventLogAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enterTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn графикDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn подразделениеDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn типUIDDataGridViewTextBoxColumn;
	}
}