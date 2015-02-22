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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Настройки");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Узел2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Узел3");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Администрирование", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.systemUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aC_DataSet = new SerialPortUsing.Access_control_in_OneWire();
            this.staffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemUsersTableAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.SystemUsersTableAdapter();
            this.staffTableAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.StaffTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.насстройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.панельНавигатораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.b_DBPath = new System.Windows.Forms.Button();
            this.b_saveConfig = new System.Windows.Forms.Button();
            this.tb_dbpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_speed = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aC_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemUsersBindingSource1
            // 
            this.systemUsersBindingSource1.DataMember = "SystemUsers";
            this.systemUsersBindingSource1.DataSource = this.aC_DataSet;
            // 
            // aC_DataSet
            // 
            this.aC_DataSet.DataSetName = "AC_DataSet";
            this.aC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource1
            // 
            this.staffBindingSource1.DataMember = "Staff";
            this.staffBindingSource1.DataSource = this.aC_DataSet;
            // 
            // systemUsersTableAdapter
            // 
            this.systemUsersTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(770, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Настройки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.насстройкиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.разделыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // насстройкиToolStripMenuItem
            // 
            this.насстройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.насстройкиToolStripMenuItem.Name = "насстройкиToolStripMenuItem";
            this.насстройкиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.насстройкиToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.панельНавигатораToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // панельНавигатораToolStripMenuItem
            // 
            this.панельНавигатораToolStripMenuItem.Checked = true;
            this.панельНавигатораToolStripMenuItem.CheckOnClick = true;
            this.панельНавигатораToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.панельНавигатораToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("панельНавигатораToolStripMenuItem.Image")));
            this.панельНавигатораToolStripMenuItem.Name = "панельНавигатораToolStripMenuItem";
            this.панельНавигатораToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.панельНавигатораToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.панельНавигатораToolStripMenuItem.Text = "Панель навигатора";
            this.панельНавигатораToolStripMenuItem.Click += new System.EventHandler(this.панельНавигатораToolStripMenuItem_Click);
            // 
            // разделыToolStripMenuItem
            // 
            this.разделыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.разделыToolStripMenuItem.Name = "разделыToolStripMenuItem";
            this.разделыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.разделыToolStripMenuItem.Text = "Разделы";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_DBPath);
            this.groupBox1.Controls.Add(this.b_saveConfig);
            this.groupBox1.Controls.Add(this.tb_dbpath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_ComPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_speed);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(150, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 414);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(257, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 414);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 27);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Option";
            treeNode9.Text = "Настройки";
            treeNode10.Name = "Узел2";
            treeNode10.Text = "Узел2";
            treeNode11.Name = "Узел3";
            treeNode11.Text = "Узел3";
            treeNode12.BackColor = System.Drawing.Color.Transparent;
            treeNode12.Name = "Узел0";
            treeNode12.Text = "Администрирование";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(132, 414);
            this.treeView1.TabIndex = 3;
            // 
            // b_DBPath
            // 
            this.b_DBPath.Location = new System.Drawing.Point(207, 73);
            this.b_DBPath.Name = "b_DBPath";
            this.b_DBPath.Size = new System.Drawing.Size(27, 23);
            this.b_DBPath.TabIndex = 15;
            this.b_DBPath.Text = "...";
            this.b_DBPath.UseVisualStyleBackColor = true;
            this.b_DBPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // b_saveConfig
            // 
            this.b_saveConfig.Location = new System.Drawing.Point(87, 100);
            this.b_saveConfig.Name = "b_saveConfig";
            this.b_saveConfig.Size = new System.Drawing.Size(75, 23);
            this.b_saveConfig.TabIndex = 14;
            this.b_saveConfig.Text = "Save";
            this.b_saveConfig.UseVisualStyleBackColor = true;
            this.b_saveConfig.Click += new System.EventHandler(this.b_saveConfig_Click_1);
            // 
            // tb_dbpath
            // 
            this.tb_dbpath.Location = new System.Drawing.Point(87, 74);
            this.tb_dbpath.Name = "tb_dbpath";
            this.tb_dbpath.Size = new System.Drawing.Size(121, 20);
            this.tb_dbpath.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "DB file path";
            // 
            // cb_ComPort
            // 
            this.cb_ComPort.FormattingEnabled = true;
            this.cb_ComPort.Location = new System.Drawing.Point(87, 45);
            this.cb_ComPort.Name = "cb_ComPort";
            this.cb_ComPort.Size = new System.Drawing.Size(147, 21);
            this.cb_ComPort.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Com port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Скорость bps";
            // 
            // cb_speed
            // 
            this.cb_speed.FormattingEnabled = true;
            this.cb_speed.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cb_speed.Location = new System.Drawing.Point(87, 13);
            this.cb_speed.Name = "cb_speed";
            this.cb_speed.Size = new System.Drawing.Size(147, 21);
            this.cb_speed.TabIndex = 8;
            this.cb_speed.Text = "9600";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Администрирование СКУД";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aC_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.BindingSource systemUsersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn типПользователяDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource staffBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поле1DataGridViewTextBoxColumn;
        private Access_control_in_OneWire aC_DataSet;
		private System.Windows.Forms.BindingSource systemUsersBindingSource1;
		private Access_control_in_OneWireTableAdapters.SystemUsersTableAdapter systemUsersTableAdapter;
		private System.Windows.Forms.BindingSource staffBindingSource1;
		private Access_control_in_OneWireTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem насстройкиToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельНавигатораToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_DBPath;
        private System.Windows.Forms.Button b_saveConfig;
        private System.Windows.Forms.TextBox tb_dbpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_speed;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}