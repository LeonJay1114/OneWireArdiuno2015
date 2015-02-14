namespace SerialPortUsing {
	partial class AdminForm {
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.поле1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabC_rawData = new System.Windows.Forms.TabControl();
			this.tab_users = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.systemUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tab_staff = new System.Windows.Forms.TabPage();
			this.tab_log = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.aC_DataSet = new SerialPortUsing.Access_control_in_OneWire();
			this.systemUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemUsersTableAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.SystemUsersTableAdapter();
			this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.StaffTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
			this.tabC_rawData.SuspendLayout();
			this.tab_users.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource)).BeginInit();
			this.tab_staff.SuspendLayout();
			this.tab_log.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.aC_DataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.поле1DataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn1});
			this.dataGridView1.DataSource = this.staffBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(793, 391);
			this.dataGridView1.TabIndex = 0;
			// 
			// фамилияDataGridViewTextBoxColumn
			// 
			this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
			// 
			// имяDataGridViewTextBoxColumn
			// 
			this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
			this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
			// 
			// отчествоDataGridViewTextBoxColumn
			// 
			this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
			// 
			// должностьDataGridViewTextBoxColumn
			// 
			this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
			this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
			// 
			// поле1DataGridViewTextBoxColumn
			// 
			this.поле1DataGridViewTextBoxColumn.DataPropertyName = "Поле1";
			this.поле1DataGridViewTextBoxColumn.HeaderText = "Поле1";
			this.поле1DataGridViewTextBoxColumn.Name = "поле1DataGridViewTextBoxColumn";
			// 
			// uIDDataGridViewTextBoxColumn1
			// 
			this.uIDDataGridViewTextBoxColumn1.DataPropertyName = "UID";
			this.uIDDataGridViewTextBoxColumn1.HeaderText = "UID";
			this.uIDDataGridViewTextBoxColumn1.Name = "uIDDataGridViewTextBoxColumn1";
			// 
			// tabC_rawData
			// 
			this.tabC_rawData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabC_rawData.Controls.Add(this.tab_users);
			this.tabC_rawData.Controls.Add(this.tab_staff);
			this.tabC_rawData.Controls.Add(this.tab_log);
			this.tabC_rawData.Location = new System.Drawing.Point(12, 12);
			this.tabC_rawData.Name = "tabC_rawData";
			this.tabC_rawData.SelectedIndex = 0;
			this.tabC_rawData.Size = new System.Drawing.Size(813, 429);
			this.tabC_rawData.TabIndex = 1;
			// 
			// tab_users
			// 
			this.tab_users.Controls.Add(this.dataGridView2);
			this.tab_users.Location = new System.Drawing.Point(4, 22);
			this.tab_users.Name = "tab_users";
			this.tab_users.Padding = new System.Windows.Forms.Padding(3);
			this.tab_users.Size = new System.Drawing.Size(805, 403);
			this.tab_users.TabIndex = 1;
			this.tab_users.Text = "Пользователи СКУД";
			this.tab_users.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.типПользователяDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.systemUsersBindingSource1;
			this.dataGridView2.Location = new System.Drawing.Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(793, 391);
			this.dataGridView2.TabIndex = 1;
			// 
			// uidDataGridViewTextBoxColumn
			// 
			this.uidDataGridViewTextBoxColumn.DataPropertyName = "Uid";
			this.uidDataGridViewTextBoxColumn.HeaderText = "Uid";
			this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
			// 
			// типПользователяDataGridViewTextBoxColumn
			// 
			this.типПользователяDataGridViewTextBoxColumn.DataPropertyName = "Тип пользователя";
			this.типПользователяDataGridViewTextBoxColumn.HeaderText = "Тип пользователя";
			this.типПользователяDataGridViewTextBoxColumn.Name = "типПользователяDataGridViewTextBoxColumn";
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			// 
			// tab_staff
			// 
			this.tab_staff.Controls.Add(this.dataGridView1);
			this.tab_staff.Location = new System.Drawing.Point(4, 22);
			this.tab_staff.Name = "tab_staff";
			this.tab_staff.Padding = new System.Windows.Forms.Padding(3);
			this.tab_staff.Size = new System.Drawing.Size(805, 403);
			this.tab_staff.TabIndex = 0;
			this.tab_staff.Text = "Персонал";
			this.tab_staff.UseVisualStyleBackColor = true;
			// 
			// tab_log
			// 
			this.tab_log.Controls.Add(this.dataGridView3);
			this.tab_log.Location = new System.Drawing.Point(4, 22);
			this.tab_log.Name = "tab_log";
			this.tab_log.Size = new System.Drawing.Size(805, 403);
			this.tab_log.TabIndex = 2;
			this.tab_log.Text = "Журнал пропускания";
			this.tab_log.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(6, 6);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(793, 391);
			this.dataGridView3.TabIndex = 1;
			// 
			// aC_DataSet
			// 
			this.aC_DataSet.DataSetName = "AC_DataSet";
			this.aC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// systemUsersBindingSource1
			// 
			this.systemUsersBindingSource1.DataMember = "SystemUsers";
			this.systemUsersBindingSource1.DataSource = this.aC_DataSet;
			// 
			// systemUsersTableAdapter
			// 
			this.systemUsersTableAdapter.ClearBeforeFill = true;
			// 
			// staffBindingSource1
			// 
			this.staffBindingSource1.DataMember = "Staff";
			this.staffBindingSource1.DataSource = this.aC_DataSet;
			// 
			// staffTableAdapter
			// 
			this.staffTableAdapter.ClearBeforeFill = true;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 453);
			this.Controls.Add(this.tabC_rawData);
			this.Name = "AdminForm";
			this.Text = "Администрирование СКУД";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
			this.tabC_rawData.ResumeLayout(false);
			this.tab_users.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource)).EndInit();
			this.tab_staff.ResumeLayout(false);
			this.tab_log.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.aC_DataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabControl tabC_rawData;
		private System.Windows.Forms.TabPage tab_users;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TabPage tab_staff;
		private System.Windows.Forms.TabPage tab_log;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.BindingSource systemUsersBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn типПользователяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource staffBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn поле1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn1;
        private Access_control_in_OneWire aC_DataSet;
		private System.Windows.Forms.BindingSource systemUsersBindingSource1;
		private Access_control_in_OneWireTableAdapters.SystemUsersTableAdapter systemUsersTableAdapter;
		private System.Windows.Forms.BindingSource staffBindingSource1;
		private Access_control_in_OneWireTableAdapters.StaffTableAdapter staffTableAdapter;
	}
}