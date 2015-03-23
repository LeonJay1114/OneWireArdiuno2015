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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Основное");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Система", new System.Windows.Forms.TreeNode[] {
            treeNode1});
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Пользователи");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Сотрудники");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Журнал пропуска");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("База", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.насстройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.панельНавигатораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.разделыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.основноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.базаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.журналПропускаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.кАКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gb_sys = new System.Windows.Forms.GroupBox();
			this.b_DBPath = new System.Windows.Forms.Button();
			this.b_saveConfig = new System.Windows.Forms.Button();
			this.tb_dbpath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cb_ComPort = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_speed = new System.Windows.Forms.ComboBox();
			this.gb_users = new System.Windows.Forms.GroupBox();
			this.gb_usersEdit = new System.Windows.Forms.GroupBox();
			this.chB_users_hidePass = new System.Windows.Forms.CheckBox();
			this.b_delUser = new System.Windows.Forms.Button();
			this.b_editUser = new System.Windows.Forms.Button();
			this.b_addUser = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cB_userType = new System.Windows.Forms.ComboBox();
			this.tB_password = new System.Windows.Forms.TextBox();
			this.tB_login = new System.Windows.Forms.TextBox();
			this.dgv_users = new System.Windows.Forms.DataGridView();
			this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.systemUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.access_control_in_OneWire = new SerialPortUsing.Access_control_in_OneWire();
			this.gb_staff = new System.Windows.Forms.GroupBox();
			this.dgv_staff = new System.Windows.Forms.DataGridView();
			this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фотоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.табельныйНомерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.датаНаймаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.графикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.заблокированDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.подразделениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.b_readUIDStaff = new System.Windows.Forms.Button();
			this.cB_UID_type_from_gb_staff = new System.Windows.Forms.ComboBox();
			this.cB_subdivision = new System.Windows.Forms.ComboBox();
			this.cB_blocked = new System.Windows.Forms.CheckBox();
			this.cB_workTime = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.b_choosePhoto = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tB_number = new System.Windows.Forms.TextBox();
			this.tB_UID_from_gb_staff = new System.Windows.Forms.TextBox();
			this.tB_multiPasport = new System.Windows.Forms.TextBox();
			this.tB_photoPath = new System.Windows.Forms.TextBox();
			this.tB_staff = new System.Windows.Forms.TextBox();
			this.cB_profession = new System.Windows.Forms.ComboBox();
			this.b_edditStaff = new System.Windows.Forms.Button();
			this.b_delStaff = new System.Windows.Forms.Button();
			this.b_addStaff = new System.Windows.Forms.Button();
			this.tv_navigation = new System.Windows.Forms.TreeView();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.gB_event = new System.Windows.Forms.GroupBox();
			this.pic_event_photo = new System.Windows.Forms.PictureBox();
			this.gB_period = new System.Windows.Forms.GroupBox();
			this.b_setPeriod_PastMonth = new System.Windows.Forms.Button();
			this.b_setPeriod_ThisMonth = new System.Windows.Forms.Button();
			this.b_setPeriod_Last10Days = new System.Windows.Forms.Button();
			this.b_setPeriod_PastWeek = new System.Windows.Forms.Button();
			this.b_setPeriod_PastDay = new System.Windows.Forms.Button();
			this.b_showEvent = new System.Windows.Forms.Button();
			this.dtp_eventStart = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.dtp_eventEnd = new System.Windows.Forms.DateTimePicker();
			this.dgv_event = new System.Windows.Forms.DataGridView();
			this.сотрудникDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.должностьDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.фотоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enterTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.табельныйНомерDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерПаспортаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.графикDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.подразделениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.типUIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.joinedEventLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.staffTableAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.StaffTableAdapter();
			this.joinedEventLogAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.JoinedEventLogAdapter();
			this.systemUsersTableAdapter = new SerialPortUsing.Access_control_in_OneWireTableAdapters.SystemUsersTableAdapter();
			this.menuStrip1.SuspendLayout();
			this.gb_sys.SuspendLayout();
			this.gb_users.SuspendLayout();
			this.gb_usersEdit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.access_control_in_OneWire)).BeginInit();
			this.gb_staff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.gB_event.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic_event_photo)).BeginInit();
			this.gB_period.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_event)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.joinedEventLogBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.насстройкиToolStripMenuItem,
            this.видToolStripMenuItem,
            this.разделыToolStripMenuItem,
            this.справкаToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1322, 24);
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
            this.администрированиеToolStripMenuItem,
            this.базаToolStripMenuItem});
			this.разделыToolStripMenuItem.Name = "разделыToolStripMenuItem";
			this.разделыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.разделыToolStripMenuItem.Text = "Разделы";
			// 
			// администрированиеToolStripMenuItem
			// 
			this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основноеToolStripMenuItem});
			this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
			this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.администрированиеToolStripMenuItem.Text = "Система";
			// 
			// основноеToolStripMenuItem
			// 
			this.основноеToolStripMenuItem.Name = "основноеToolStripMenuItem";
			this.основноеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
			this.основноеToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.основноеToolStripMenuItem.Text = "Основное";
			this.основноеToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenuClick);
			// 
			// базаToolStripMenuItem
			// 
			this.базаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.журналПропускаToolStripMenuItem});
			this.базаToolStripMenuItem.Name = "базаToolStripMenuItem";
			this.базаToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.базаToolStripMenuItem.Text = "База";
			// 
			// пользователиToolStripMenuItem
			// 
			this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
			this.пользователиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.U)));
			this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.пользователиToolStripMenuItem.Text = "Пользователи";
			this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenuClick);
			// 
			// сотрудникиToolStripMenuItem
			// 
			this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
			this.сотрудникиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
			this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenuClick);
			// 
			// журналПропускаToolStripMenuItem
			// 
			this.журналПропускаToolStripMenuItem.Name = "журналПропускаToolStripMenuItem";
			this.журналПропускаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
			this.журналПропускаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.журналПропускаToolStripMenuItem.Text = "Журнал пропуска";
			this.журналПропускаToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenuClick);
			// 
			// справкаToolStripMenuItem
			// 
			this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кАКToolStripMenuItem});
			this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
			this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.справкаToolStripMenuItem.Text = "Справка";
			// 
			// кАКToolStripMenuItem
			// 
			this.кАКToolStripMenuItem.Name = "кАКToolStripMenuItem";
			this.кАКToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.кАКToolStripMenuItem.Text = "КАК?!";
			// 
			// gb_sys
			// 
			this.gb_sys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_sys.Controls.Add(this.b_DBPath);
			this.gb_sys.Controls.Add(this.b_saveConfig);
			this.gb_sys.Controls.Add(this.tb_dbpath);
			this.gb_sys.Controls.Add(this.label3);
			this.gb_sys.Controls.Add(this.cb_ComPort);
			this.gb_sys.Controls.Add(this.label2);
			this.gb_sys.Controls.Add(this.label1);
			this.gb_sys.Controls.Add(this.cb_speed);
			this.gb_sys.Location = new System.Drawing.Point(174, 547);
			this.gb_sys.Name = "gb_sys";
			this.gb_sys.Size = new System.Drawing.Size(100, 158);
			this.gb_sys.TabIndex = 2;
			this.gb_sys.TabStop = false;
			this.gb_sys.Text = "gb_sys";
			// 
			// b_DBPath
			// 
			this.b_DBPath.Location = new System.Drawing.Point(207, 73);
			this.b_DBPath.Name = "b_DBPath";
			this.b_DBPath.Size = new System.Drawing.Size(27, 23);
			this.b_DBPath.TabIndex = 15;
			this.b_DBPath.Text = "...";
			this.b_DBPath.UseVisualStyleBackColor = true;
			this.b_DBPath.Click += new System.EventHandler(this.b_DBPath_Click);
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
			// gb_users
			// 
			this.gb_users.Controls.Add(this.gb_usersEdit);
			this.gb_users.Controls.Add(this.dgv_users);
			this.gb_users.Location = new System.Drawing.Point(388, 549);
			this.gb_users.Name = "gb_users";
			this.gb_users.Size = new System.Drawing.Size(60, 350);
			this.gb_users.TabIndex = 3;
			this.gb_users.TabStop = false;
			this.gb_users.Text = "gb_users";
			// 
			// gb_usersEdit
			// 
			this.gb_usersEdit.Controls.Add(this.chB_users_hidePass);
			this.gb_usersEdit.Controls.Add(this.b_delUser);
			this.gb_usersEdit.Controls.Add(this.b_editUser);
			this.gb_usersEdit.Controls.Add(this.b_addUser);
			this.gb_usersEdit.Controls.Add(this.label7);
			this.gb_usersEdit.Controls.Add(this.label6);
			this.gb_usersEdit.Controls.Add(this.label5);
			this.gb_usersEdit.Controls.Add(this.cB_userType);
			this.gb_usersEdit.Controls.Add(this.tB_password);
			this.gb_usersEdit.Controls.Add(this.tB_login);
			this.gb_usersEdit.Location = new System.Drawing.Point(9, 235);
			this.gb_usersEdit.Name = "gb_usersEdit";
			this.gb_usersEdit.Size = new System.Drawing.Size(1115, 166);
			this.gb_usersEdit.TabIndex = 1;
			this.gb_usersEdit.TabStop = false;
			this.gb_usersEdit.Text = "gb_usersEdit";
			// 
			// chB_users_hidePass
			// 
			this.chB_users_hidePass.AutoSize = true;
			this.chB_users_hidePass.Location = new System.Drawing.Point(402, 32);
			this.chB_users_hidePass.Name = "chB_users_hidePass";
			this.chB_users_hidePass.Size = new System.Drawing.Size(53, 17);
			this.chB_users_hidePass.TabIndex = 11;
			this.chB_users_hidePass.Text = "Show";
			this.chB_users_hidePass.UseVisualStyleBackColor = true;
			this.chB_users_hidePass.CheckedChanged += new System.EventHandler(this.chB_users_hidePass_CheckedChanged);
			// 
			// b_delUser
			// 
			this.b_delUser.Location = new System.Drawing.Point(101, 76);
			this.b_delUser.Name = "b_delUser";
			this.b_delUser.Size = new System.Drawing.Size(75, 23);
			this.b_delUser.TabIndex = 10;
			this.b_delUser.Text = "Удалить";
			this.b_delUser.UseVisualStyleBackColor = true;
			this.b_delUser.Click += new System.EventHandler(this.b_delUser_Click);
			// 
			// b_editUser
			// 
			this.b_editUser.Location = new System.Drawing.Point(263, 76);
			this.b_editUser.Name = "b_editUser";
			this.b_editUser.Size = new System.Drawing.Size(93, 23);
			this.b_editUser.TabIndex = 9;
			this.b_editUser.Text = "Заменить";
			this.b_editUser.UseVisualStyleBackColor = true;
			this.b_editUser.Click += new System.EventHandler(this.b_editUser_Click);
			// 
			// b_addUser
			// 
			this.b_addUser.Location = new System.Drawing.Point(182, 76);
			this.b_addUser.Name = "b_addUser";
			this.b_addUser.Size = new System.Drawing.Size(75, 23);
			this.b_addUser.TabIndex = 8;
			this.b_addUser.Text = "Добавить";
			this.b_addUser.UseVisualStyleBackColor = true;
			this.b_addUser.Click += new System.EventHandler(this.b_addUser_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(244, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Password";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(162, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Login";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "User Type";
			// 
			// cB_userType
			// 
			this.cB_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cB_userType.FormattingEnabled = true;
			this.cB_userType.Items.AddRange(new object[] {
            "Boss",
            "Admin",
            "Security"});
			this.cB_userType.Location = new System.Drawing.Point(14, 32);
			this.cB_userType.Name = "cB_userType";
			this.cB_userType.Size = new System.Drawing.Size(121, 21);
			this.cB_userType.TabIndex = 3;
			// 
			// tB_password
			// 
			this.tB_password.Location = new System.Drawing.Point(247, 32);
			this.tB_password.Name = "tB_password";
			this.tB_password.PasswordChar = '•';
			this.tB_password.Size = new System.Drawing.Size(149, 20);
			this.tB_password.TabIndex = 2;
			// 
			// tB_login
			// 
			this.tB_login.Location = new System.Drawing.Point(141, 32);
			this.tB_login.Name = "tB_login";
			this.tB_login.Size = new System.Drawing.Size(100, 20);
			this.tB_login.TabIndex = 1;
			this.tB_login.Text = "Bosyaka";
			// 
			// dgv_users
			// 
			this.dgv_users.AllowUserToAddRows = false;
			this.dgv_users.AllowUserToDeleteRows = false;
			this.dgv_users.AllowUserToResizeColumns = false;
			this.dgv_users.AllowUserToResizeRows = false;
			this.dgv_users.AutoGenerateColumns = false;
			this.dgv_users.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userTypeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn});
			this.dgv_users.DataSource = this.systemUsersBindingSource;
			this.dgv_users.Location = new System.Drawing.Point(8, 20);
			this.dgv_users.Name = "dgv_users";
			this.dgv_users.ReadOnly = true;
			this.dgv_users.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_users.Size = new System.Drawing.Size(1116, 209);
			this.dgv_users.TabIndex = 0;
			this.dgv_users.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellDoubleClick);
			// 
			// userTypeDataGridViewTextBoxColumn
			// 
			this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
			this.userTypeDataGridViewTextBoxColumn.HeaderText = "userType";
			this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
			this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// systemUsersBindingSource
			// 
			this.systemUsersBindingSource.DataMember = "SystemUsers";
			this.systemUsersBindingSource.DataSource = this.access_control_in_OneWire;
			// 
			// access_control_in_OneWire
			// 
			this.access_control_in_OneWire.DataSetName = "Access_control_in_OneWire";
			this.access_control_in_OneWire.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gb_staff
			// 
			this.gb_staff.Controls.Add(this.dgv_staff);
			this.gb_staff.Controls.Add(this.groupBox2);
			this.gb_staff.Location = new System.Drawing.Point(575, 547);
			this.gb_staff.Name = "gb_staff";
			this.gb_staff.Size = new System.Drawing.Size(139, 461);
			this.gb_staff.TabIndex = 4;
			this.gb_staff.TabStop = false;
			this.gb_staff.Text = "gb_staff";
			// 
			// dgv_staff
			// 
			this.dgv_staff.AllowUserToAddRows = false;
			this.dgv_staff.AllowUserToDeleteRows = false;
			this.dgv_staff.AllowUserToResizeColumns = false;
			this.dgv_staff.AllowUserToResizeRows = false;
			this.dgv_staff.AutoGenerateColumns = false;
			this.dgv_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgv_staff.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv_staff.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_staff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.сотрудникDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.фотоDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn1,
            this.табельныйНомерDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.датаНаймаDataGridViewTextBoxColumn,
            this.графикDataGridViewTextBoxColumn,
            this.заблокированDataGridViewCheckBoxColumn,
            this.подразделениеDataGridViewTextBoxColumn,
            this.типUIDDataGridViewTextBoxColumn});
			this.dgv_staff.DataSource = this.staffBindingSource;
			this.dgv_staff.Location = new System.Drawing.Point(12, 19);
			this.dgv_staff.Name = "dgv_staff";
			this.dgv_staff.ReadOnly = true;
			this.dgv_staff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_staff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_staff.Size = new System.Drawing.Size(956, 273);
			this.dgv_staff.TabIndex = 0;
			this.dgv_staff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_staff_CellDoubleClick);
			// 
			// сотрудникDataGridViewTextBoxColumn
			// 
			this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
			this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
			this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
			this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
			this.сотрудникDataGridViewTextBoxColumn.Width = 85;
			// 
			// должностьDataGridViewTextBoxColumn
			// 
			this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
			this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
			this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
			this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
			this.должностьDataGridViewTextBoxColumn.Width = 90;
			// 
			// фотоDataGridViewTextBoxColumn
			// 
			this.фотоDataGridViewTextBoxColumn.DataPropertyName = "Фото";
			this.фотоDataGridViewTextBoxColumn.HeaderText = "Фото";
			this.фотоDataGridViewTextBoxColumn.Name = "фотоDataGridViewTextBoxColumn";
			this.фотоDataGridViewTextBoxColumn.ReadOnly = true;
			this.фотоDataGridViewTextBoxColumn.Width = 60;
			// 
			// uIDDataGridViewTextBoxColumn1
			// 
			this.uIDDataGridViewTextBoxColumn1.DataPropertyName = "UID";
			this.uIDDataGridViewTextBoxColumn1.HeaderText = "UID";
			this.uIDDataGridViewTextBoxColumn1.Name = "uIDDataGridViewTextBoxColumn1";
			this.uIDDataGridViewTextBoxColumn1.ReadOnly = true;
			this.uIDDataGridViewTextBoxColumn1.Width = 51;
			// 
			// табельныйНомерDataGridViewTextBoxColumn
			// 
			this.табельныйНомерDataGridViewTextBoxColumn.DataPropertyName = "Табельный номер";
			this.табельныйНомерDataGridViewTextBoxColumn.HeaderText = "Табельный номер";
			this.табельныйНомерDataGridViewTextBoxColumn.Name = "табельныйНомерDataGridViewTextBoxColumn";
			this.табельныйНомерDataGridViewTextBoxColumn.ReadOnly = true;
			this.табельныйНомерDataGridViewTextBoxColumn.Width = 114;
			// 
			// номерПаспортаDataGridViewTextBoxColumn
			// 
			this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
			this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
			this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
			this.номерПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
			this.номерПаспортаDataGridViewTextBoxColumn.Width = 106;
			// 
			// датаНаймаDataGridViewTextBoxColumn
			// 
			this.датаНаймаDataGridViewTextBoxColumn.DataPropertyName = "Дата найма";
			this.датаНаймаDataGridViewTextBoxColumn.HeaderText = "Дата найма";
			this.датаНаймаDataGridViewTextBoxColumn.Name = "датаНаймаDataGridViewTextBoxColumn";
			this.датаНаймаDataGridViewTextBoxColumn.ReadOnly = true;
			this.датаНаймаDataGridViewTextBoxColumn.Width = 86;
			// 
			// графикDataGridViewTextBoxColumn
			// 
			this.графикDataGridViewTextBoxColumn.DataPropertyName = "График";
			this.графикDataGridViewTextBoxColumn.HeaderText = "График";
			this.графикDataGridViewTextBoxColumn.Name = "графикDataGridViewTextBoxColumn";
			this.графикDataGridViewTextBoxColumn.ReadOnly = true;
			this.графикDataGridViewTextBoxColumn.Width = 70;
			// 
			// заблокированDataGridViewCheckBoxColumn
			// 
			this.заблокированDataGridViewCheckBoxColumn.DataPropertyName = "Заблокирован";
			this.заблокированDataGridViewCheckBoxColumn.HeaderText = "Заблокирован";
			this.заблокированDataGridViewCheckBoxColumn.Name = "заблокированDataGridViewCheckBoxColumn";
			this.заблокированDataGridViewCheckBoxColumn.ReadOnly = true;
			this.заблокированDataGridViewCheckBoxColumn.Width = 86;
			// 
			// подразделениеDataGridViewTextBoxColumn
			// 
			this.подразделениеDataGridViewTextBoxColumn.DataPropertyName = "Подразделение";
			this.подразделениеDataGridViewTextBoxColumn.HeaderText = "Подразделение";
			this.подразделениеDataGridViewTextBoxColumn.Name = "подразделениеDataGridViewTextBoxColumn";
			this.подразделениеDataGridViewTextBoxColumn.ReadOnly = true;
			this.подразделениеDataGridViewTextBoxColumn.Width = 112;
			// 
			// типUIDDataGridViewTextBoxColumn
			// 
			this.типUIDDataGridViewTextBoxColumn.DataPropertyName = "Тип UID";
			this.типUIDDataGridViewTextBoxColumn.HeaderText = "Тип UID";
			this.типUIDDataGridViewTextBoxColumn.Name = "типUIDDataGridViewTextBoxColumn";
			this.типUIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.типUIDDataGridViewTextBoxColumn.Width = 51;
			// 
			// staffBindingSource
			// 
			this.staffBindingSource.DataMember = "Staff";
			this.staffBindingSource.DataSource = this.access_control_in_OneWire;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.b_readUIDStaff);
			this.groupBox2.Controls.Add(this.cB_UID_type_from_gb_staff);
			this.groupBox2.Controls.Add(this.cB_subdivision);
			this.groupBox2.Controls.Add(this.cB_blocked);
			this.groupBox2.Controls.Add(this.cB_workTime);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.b_choosePhoto);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.tB_number);
			this.groupBox2.Controls.Add(this.tB_UID_from_gb_staff);
			this.groupBox2.Controls.Add(this.tB_multiPasport);
			this.groupBox2.Controls.Add(this.tB_photoPath);
			this.groupBox2.Controls.Add(this.tB_staff);
			this.groupBox2.Controls.Add(this.cB_profession);
			this.groupBox2.Controls.Add(this.b_edditStaff);
			this.groupBox2.Controls.Add(this.b_delStaff);
			this.groupBox2.Controls.Add(this.b_addStaff);
			this.groupBox2.Location = new System.Drawing.Point(12, 298);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(929, 142);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "gB_staffEdit";
			// 
			// b_readUIDStaff
			// 
			this.b_readUIDStaff.Location = new System.Drawing.Point(484, 33);
			this.b_readUIDStaff.Name = "b_readUIDStaff";
			this.b_readUIDStaff.Size = new System.Drawing.Size(15, 21);
			this.b_readUIDStaff.TabIndex = 37;
			this.b_readUIDStaff.Text = "<";
			this.toolTip1.SetToolTip(this.b_readUIDStaff, "Прочитать UID");
			this.b_readUIDStaff.UseVisualStyleBackColor = true;
			this.b_readUIDStaff.Click += new System.EventHandler(this.b_readUIDStaff_Click);
			// 
			// cB_UID_type_from_gb_staff
			// 
			this.cB_UID_type_from_gb_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cB_UID_type_from_gb_staff.FormattingEnabled = true;
			this.cB_UID_type_from_gb_staff.Items.AddRange(new object[] {
            "Недельная",
            "Годовая",
            "2х годовая"});
			this.cB_UID_type_from_gb_staff.Location = new System.Drawing.Point(411, 85);
			this.cB_UID_type_from_gb_staff.Name = "cB_UID_type_from_gb_staff";
			this.cB_UID_type_from_gb_staff.Size = new System.Drawing.Size(121, 21);
			this.cB_UID_type_from_gb_staff.TabIndex = 36;
			// 
			// cB_subdivision
			// 
			this.cB_subdivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cB_subdivision.FormattingEnabled = true;
			this.cB_subdivision.Items.AddRange(new object[] {
            "Начальника",
            "Уборщики",
            "Технический персонал",
            "Научный персонал"});
			this.cB_subdivision.Location = new System.Drawing.Point(272, 87);
			this.cB_subdivision.Name = "cB_subdivision";
			this.cB_subdivision.Size = new System.Drawing.Size(121, 21);
			this.cB_subdivision.TabIndex = 35;
			// 
			// cB_blocked
			// 
			this.cB_blocked.AutoSize = true;
			this.cB_blocked.Location = new System.Drawing.Point(167, 87);
			this.cB_blocked.Name = "cB_blocked";
			this.cB_blocked.Size = new System.Drawing.Size(99, 17);
			this.cB_blocked.TabIndex = 34;
			this.cB_blocked.Text = "Заблокирован";
			this.cB_blocked.UseVisualStyleBackColor = true;
			// 
			// cB_workTime
			// 
			this.cB_workTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cB_workTime.FormattingEnabled = true;
			this.cB_workTime.Items.AddRange(new object[] {
            "8.00-18.00",
            "9.00-19.00",
            "13.00-16.00"});
			this.cB_workTime.Location = new System.Drawing.Point(19, 87);
			this.cB_workTime.Name = "cB_workTime";
			this.cB_workTime.Size = new System.Drawing.Size(121, 21);
			this.cB_workTime.TabIndex = 33;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(726, 34);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(174, 20);
			this.dateTimePicker1.TabIndex = 31;
			this.dateTimePicker1.Value = new System.DateTime(2015, 3, 6, 18, 47, 0, 0);
			// 
			// b_choosePhoto
			// 
			this.b_choosePhoto.Location = new System.Drawing.Point(357, 30);
			this.b_choosePhoto.Name = "b_choosePhoto";
			this.b_choosePhoto.Size = new System.Drawing.Size(24, 23);
			this.b_choosePhoto.TabIndex = 30;
			this.b_choosePhoto.Text = "...";
			this.b_choosePhoto.UseVisualStyleBackColor = true;
			this.b_choosePhoto.Click += new System.EventHandler(this.b_choosePhoto_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(441, 69);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(49, 13);
			this.label17.TabIndex = 28;
			this.label17.Text = "UID type";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(55, 71);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(45, 13);
			this.label16.TabIndex = 27;
			this.label16.Text = "График";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(278, 71);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(87, 13);
			this.label15.TabIndex = 26;
			this.label15.Text = "Подразделение";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(750, 18);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(68, 13);
			this.label14.TabIndex = 25;
			this.label14.Text = "Дата найма";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(615, 18);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(91, 13);
			this.label13.TabIndex = 24;
			this.label13.Text = "Номер паспорта";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(506, 18);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(99, 13);
			this.label12.TabIndex = 23;
			this.label12.Text = "Табельный номер";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(423, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(26, 13);
			this.label11.TabIndex = 22;
			this.label11.Text = "UID";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(290, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(35, 13);
			this.label10.TabIndex = 21;
			this.label10.Text = "Фото";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(153, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "Должность";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Сотрудник";
			// 
			// tB_number
			// 
			this.tB_number.Location = new System.Drawing.Point(505, 34);
			this.tB_number.Name = "tB_number";
			this.tB_number.ReadOnly = true;
			this.tB_number.Size = new System.Drawing.Size(100, 20);
			this.tB_number.TabIndex = 18;
			// 
			// tB_UID_from_gb_staff
			// 
			this.tB_UID_from_gb_staff.Location = new System.Drawing.Point(390, 33);
			this.tB_UID_from_gb_staff.Name = "tB_UID_from_gb_staff";
			this.tB_UID_from_gb_staff.Size = new System.Drawing.Size(100, 20);
			this.tB_UID_from_gb_staff.TabIndex = 17;
			// 
			// tB_multiPasport
			// 
			this.tB_multiPasport.Location = new System.Drawing.Point(611, 34);
			this.tB_multiPasport.Name = "tB_multiPasport";
			this.tB_multiPasport.Size = new System.Drawing.Size(100, 20);
			this.tB_multiPasport.TabIndex = 16;
			// 
			// tB_photoPath
			// 
			this.tB_photoPath.Location = new System.Drawing.Point(259, 32);
			this.tB_photoPath.Name = "tB_photoPath";
			this.tB_photoPath.Size = new System.Drawing.Size(100, 20);
			this.tB_photoPath.TabIndex = 15;
			// 
			// tB_staff
			// 
			this.tB_staff.Location = new System.Drawing.Point(19, 34);
			this.tB_staff.Name = "tB_staff";
			this.tB_staff.Size = new System.Drawing.Size(100, 20);
			this.tB_staff.TabIndex = 14;
			// 
			// cB_profession
			// 
			this.cB_profession.FormattingEnabled = true;
			this.cB_profession.Items.AddRange(new object[] {
            "Директор",
            "Старший помошник младшего дворника",
            "Ведущий инженер-программист",
            "Старший научный сотрудник",
            "Программист",
            "Физик-ядерщик",
            "Младший научный сотрудник",
            "Помощник программиста",
            "Старший менеджер",
            "Помошник старшего научного сотрудника"});
			this.cB_profession.Location = new System.Drawing.Point(132, 32);
			this.cB_profession.Name = "cB_profession";
			this.cB_profession.Size = new System.Drawing.Size(121, 21);
			this.cB_profession.TabIndex = 13;
			// 
			// b_edditStaff
			// 
			this.b_edditStaff.Location = new System.Drawing.Point(830, 113);
			this.b_edditStaff.Name = "b_edditStaff";
			this.b_edditStaff.Size = new System.Drawing.Size(96, 23);
			this.b_edditStaff.TabIndex = 12;
			this.b_edditStaff.Text = "Редактировать";
			this.b_edditStaff.UseVisualStyleBackColor = true;
			this.b_edditStaff.Click += new System.EventHandler(this.b_edditStaff_Click);
			// 
			// b_delStaff
			// 
			this.b_delStaff.Location = new System.Drawing.Point(749, 113);
			this.b_delStaff.Name = "b_delStaff";
			this.b_delStaff.Size = new System.Drawing.Size(75, 23);
			this.b_delStaff.TabIndex = 11;
			this.b_delStaff.Text = "Удалить";
			this.b_delStaff.UseVisualStyleBackColor = true;
			this.b_delStaff.Click += new System.EventHandler(this.b_delStaff_Click);
			// 
			// b_addStaff
			// 
			this.b_addStaff.Location = new System.Drawing.Point(668, 113);
			this.b_addStaff.Name = "b_addStaff";
			this.b_addStaff.Size = new System.Drawing.Size(75, 23);
			this.b_addStaff.TabIndex = 10;
			this.b_addStaff.Text = "Добавить";
			this.b_addStaff.UseVisualStyleBackColor = true;
			this.b_addStaff.Click += new System.EventHandler(this.b_addStaff_Click);
			// 
			// tv_navigation
			// 
			this.tv_navigation.ItemHeight = 20;
			this.tv_navigation.Location = new System.Drawing.Point(12, 27);
			this.tv_navigation.Name = "tv_navigation";
			treeNode1.Name = "Option";
			treeNode1.Text = "Основное";
			treeNode2.BackColor = System.Drawing.Color.Transparent;
			treeNode2.Name = "Узел0";
			treeNode2.Text = "Система";
			treeNode3.Name = "addUser";
			treeNode3.Text = "Пользователи";
			treeNode4.Name = "staff";
			treeNode4.Text = "Сотрудники";
			treeNode5.Name = "Узел0";
			treeNode5.Text = "Журнал пропуска";
			treeNode6.Name = "Node1";
			treeNode6.Text = "База";
			this.tv_navigation.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6});
			this.tv_navigation.Size = new System.Drawing.Size(144, 547);
			this.tv_navigation.TabIndex = 3;
			this.tv_navigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_navigation_AfterSelect);
			// 
			// gB_event
			// 
			this.gB_event.Controls.Add(this.pic_event_photo);
			this.gB_event.Controls.Add(this.gB_period);
			this.gB_event.Controls.Add(this.dgv_event);
			this.gB_event.Location = new System.Drawing.Point(162, 37);
			this.gB_event.Name = "gB_event";
			this.gB_event.Size = new System.Drawing.Size(149, 549);
			this.gB_event.TabIndex = 5;
			this.gB_event.TabStop = false;
			this.gB_event.Text = "gb_event";
			// 
			// pic_event_photo
			// 
			this.pic_event_photo.Location = new System.Drawing.Point(953, 295);
			this.pic_event_photo.Name = "pic_event_photo";
			this.pic_event_photo.Size = new System.Drawing.Size(183, 244);
			this.pic_event_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_event_photo.TabIndex = 2;
			this.pic_event_photo.TabStop = false;
			this.toolTip1.SetToolTip(this.pic_event_photo, "Поле для отоборажения фото.\r\nВыберите строку журнала, чтобы отобразить\r\nфотографи" +
        "ю проходившего.");
			// 
			// gB_period
			// 
			this.gB_period.Controls.Add(this.b_setPeriod_PastMonth);
			this.gB_period.Controls.Add(this.b_setPeriod_ThisMonth);
			this.gB_period.Controls.Add(this.b_setPeriod_Last10Days);
			this.gB_period.Controls.Add(this.b_setPeriod_PastWeek);
			this.gB_period.Controls.Add(this.b_setPeriod_PastDay);
			this.gB_period.Controls.Add(this.b_showEvent);
			this.gB_period.Controls.Add(this.dtp_eventStart);
			this.gB_period.Controls.Add(this.label18);
			this.gB_period.Controls.Add(this.label19);
			this.gB_period.Controls.Add(this.dtp_eventEnd);
			this.gB_period.Location = new System.Drawing.Point(953, 19);
			this.gB_period.Name = "gB_period";
			this.gB_period.Size = new System.Drawing.Size(189, 270);
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
			this.b_setPeriod_PastDay.Text = "Сегодня";
			this.b_setPeriod_PastDay.UseVisualStyleBackColor = true;
			this.b_setPeriod_PastDay.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// b_showEvent
			// 
			this.b_showEvent.Location = new System.Drawing.Point(14, 174);
			this.b_showEvent.Name = "b_showEvent";
			this.b_showEvent.Size = new System.Drawing.Size(169, 35);
			this.b_showEvent.TabIndex = 12;
			this.b_showEvent.Text = "Показать данные за промежуток";
			this.b_showEvent.UseVisualStyleBackColor = true;
			this.b_showEvent.Click += new System.EventHandler(this.b_setPeriod_Click);
			// 
			// dtp_eventStart
			// 
			this.dtp_eventStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_eventStart.Location = new System.Drawing.Point(44, 212);
			this.dtp_eventStart.Name = "dtp_eventStart";
			this.dtp_eventStart.Size = new System.Drawing.Size(139, 20);
			this.dtp_eventStart.TabIndex = 4;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(26, 212);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(13, 13);
			this.label18.TabIndex = 2;
			this.label18.Text = "с";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(20, 238);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(19, 13);
			this.label19.TabIndex = 3;
			this.label19.Text = "по";
			// 
			// dtp_eventEnd
			// 
			this.dtp_eventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_eventEnd.Location = new System.Drawing.Point(44, 238);
			this.dtp_eventEnd.Name = "dtp_eventEnd";
			this.dtp_eventEnd.Size = new System.Drawing.Size(140, 20);
			this.dtp_eventEnd.TabIndex = 5;
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
            this.сотрудникDataGridViewTextBoxColumn1,
            this.должностьDataGridViewTextBoxColumn1,
            this.uIDDataGridViewTextBoxColumn3,
            this.фотоDataGridViewTextBoxColumn1,
            this.enterTimeDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn,
            this.табельныйНомерDataGridViewTextBoxColumn1,
            this.номерПаспортаDataGridViewTextBoxColumn1,
            this.графикDataGridViewTextBoxColumn1,
            this.подразделениеDataGridViewTextBoxColumn1,
            this.типUIDDataGridViewTextBoxColumn1});
			this.dgv_event.DataSource = this.joinedEventLogBindingSource;
			this.dgv_event.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgv_event.Location = new System.Drawing.Point(6, 19);
			this.dgv_event.Name = "dgv_event";
			this.dgv_event.ReadOnly = true;
			this.dgv_event.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_event.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_event.Size = new System.Drawing.Size(941, 524);
			this.dgv_event.TabIndex = 0;
			this.dgv_event.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_event_CellMouseDown);
			this.dgv_event.SelectionChanged += new System.EventHandler(this.dgv_event_SelectionChanged);
			// 
			// сотрудникDataGridViewTextBoxColumn1
			// 
			this.сотрудникDataGridViewTextBoxColumn1.DataPropertyName = "Сотрудник";
			this.сотрудникDataGridViewTextBoxColumn1.HeaderText = "Сотрудник";
			this.сотрудникDataGridViewTextBoxColumn1.Name = "сотрудникDataGridViewTextBoxColumn1";
			this.сотрудникDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// должностьDataGridViewTextBoxColumn1
			// 
			this.должностьDataGridViewTextBoxColumn1.DataPropertyName = "Должность";
			this.должностьDataGridViewTextBoxColumn1.HeaderText = "Должность";
			this.должностьDataGridViewTextBoxColumn1.Name = "должностьDataGridViewTextBoxColumn1";
			this.должностьDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// uIDDataGridViewTextBoxColumn3
			// 
			this.uIDDataGridViewTextBoxColumn3.DataPropertyName = "UID";
			this.uIDDataGridViewTextBoxColumn3.HeaderText = "UID";
			this.uIDDataGridViewTextBoxColumn3.Name = "uIDDataGridViewTextBoxColumn3";
			this.uIDDataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// фотоDataGridViewTextBoxColumn1
			// 
			this.фотоDataGridViewTextBoxColumn1.DataPropertyName = "Фото";
			this.фотоDataGridViewTextBoxColumn1.HeaderText = "Фото";
			this.фотоDataGridViewTextBoxColumn1.Name = "фотоDataGridViewTextBoxColumn1";
			this.фотоDataGridViewTextBoxColumn1.ReadOnly = true;
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
			// табельныйНомерDataGridViewTextBoxColumn1
			// 
			this.табельныйНомерDataGridViewTextBoxColumn1.DataPropertyName = "Табельный номер";
			this.табельныйНомерDataGridViewTextBoxColumn1.HeaderText = "Табельный номер";
			this.табельныйНомерDataGridViewTextBoxColumn1.Name = "табельныйНомерDataGridViewTextBoxColumn1";
			this.табельныйНомерDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// номерПаспортаDataGridViewTextBoxColumn1
			// 
			this.номерПаспортаDataGridViewTextBoxColumn1.DataPropertyName = "Номер паспорта";
			this.номерПаспортаDataGridViewTextBoxColumn1.HeaderText = "Номер паспорта";
			this.номерПаспортаDataGridViewTextBoxColumn1.Name = "номерПаспортаDataGridViewTextBoxColumn1";
			this.номерПаспортаDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// графикDataGridViewTextBoxColumn1
			// 
			this.графикDataGridViewTextBoxColumn1.DataPropertyName = "График";
			this.графикDataGridViewTextBoxColumn1.HeaderText = "График";
			this.графикDataGridViewTextBoxColumn1.Name = "графикDataGridViewTextBoxColumn1";
			this.графикDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// подразделениеDataGridViewTextBoxColumn1
			// 
			this.подразделениеDataGridViewTextBoxColumn1.DataPropertyName = "Подразделение";
			this.подразделениеDataGridViewTextBoxColumn1.HeaderText = "Подразделение";
			this.подразделениеDataGridViewTextBoxColumn1.Name = "подразделениеDataGridViewTextBoxColumn1";
			this.подразделениеDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// типUIDDataGridViewTextBoxColumn1
			// 
			this.типUIDDataGridViewTextBoxColumn1.DataPropertyName = "Тип UID";
			this.типUIDDataGridViewTextBoxColumn1.HeaderText = "Тип UID";
			this.типUIDDataGridViewTextBoxColumn1.Name = "типUIDDataGridViewTextBoxColumn1";
			this.типUIDDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// joinedEventLogBindingSource
			// 
			this.joinedEventLogBindingSource.DataMember = "JoinedEventLog";
			this.joinedEventLogBindingSource.DataSource = this.access_control_in_OneWire;
			// 
			// staffTableAdapter
			// 
			this.staffTableAdapter.ClearBeforeFill = true;
			// 
			// joinedEventLogAdapter
			// 
			this.joinedEventLogAdapter.ClearBeforeFill = true;
			// 
			// systemUsersTableAdapter
			// 
			this.systemUsersTableAdapter.ClearBeforeFill = true;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1322, 586);
			this.Controls.Add(this.gB_event);
			this.Controls.Add(this.gb_staff);
			this.Controls.Add(this.tv_navigation);
			this.Controls.Add(this.gb_sys);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.gb_users);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdminForm";
			this.Text = "Администрирование СКУД";
			this.Load += new System.EventHandler(this.AdminForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.gb_sys.ResumeLayout(false);
			this.gb_sys.PerformLayout();
			this.gb_users.ResumeLayout(false);
			this.gb_usersEdit.ResumeLayout(false);
			this.gb_usersEdit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.systemUsersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.access_control_in_OneWire)).EndInit();
			this.gb_staff.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_staff)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gB_event.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic_event_photo)).EndInit();
			this.gB_period.ResumeLayout(false);
			this.gB_period.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_event)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.joinedEventLogBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn типПользователяDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поле1DataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem насстройкиToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_sys;
        private System.Windows.Forms.TreeView tv_navigation;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разделыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem панельНавигатораToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_users;
        private System.Windows.Forms.Button b_DBPath;
        private System.Windows.Forms.Button b_saveConfig;
        private System.Windows.Forms.TextBox tb_dbpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_speed;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgv_users;
		private Access_control_in_OneWire access_control_in_OneWire;
		private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.GroupBox gb_staff;
		private System.Windows.Forms.DataGridView dgv_staff;
		private System.Windows.Forms.BindingSource staffBindingSource;
        private Access_control_in_OneWireTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.GroupBox gb_usersEdit;
        private System.Windows.Forms.TextBox tB_password;
		private System.Windows.Forms.TextBox tB_login;
        private System.Windows.Forms.ComboBox cB_userType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_editUser;
        private System.Windows.Forms.Button b_addUser;
		private System.Windows.Forms.Button b_delUser;
		private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кАКToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cB_profession;
        private System.Windows.Forms.Button b_edditStaff;
        private System.Windows.Forms.Button b_delStaff;
        private System.Windows.Forms.Button b_addStaff;
        private System.Windows.Forms.Button b_choosePhoto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_number;
        private System.Windows.Forms.TextBox tB_UID_from_gb_staff;
        private System.Windows.Forms.TextBox tB_multiPasport;
        private System.Windows.Forms.TextBox tB_photoPath;
        private System.Windows.Forms.TextBox tB_staff;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНаймаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn графикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn заблокированDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn подразделениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cB_workTime;
        private System.Windows.Forms.CheckBox cB_blocked;
        private System.Windows.Forms.ComboBox cB_UID_type_from_gb_staff;
        private System.Windows.Forms.ComboBox cB_subdivision;
		private System.Windows.Forms.GroupBox gB_event;
		private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn2;
		private Access_control_in_OneWireTableAdapters.JoinedEventLogAdapter joinedEventLogAdapter;
		private System.Windows.Forms.DataGridView dgv_event;
		private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn фотоDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn enterTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn табельныйНомерDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn графикDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn подразделениеDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn типUIDDataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button b_readUIDStaff;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripMenuItem основноеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem базаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem журналПропускаToolStripMenuItem;
		private System.Windows.Forms.DateTimePicker dtp_eventEnd;
		private System.Windows.Forms.DateTimePicker dtp_eventStart;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox gB_period;
		private System.Windows.Forms.Button b_showEvent;
		private System.Windows.Forms.BindingSource joinedEventLogBindingSource;
		private System.Windows.Forms.Button b_setPeriod_PastMonth;
		private System.Windows.Forms.Button b_setPeriod_ThisMonth;
		private System.Windows.Forms.Button b_setPeriod_Last10Days;
		private System.Windows.Forms.Button b_setPeriod_PastWeek;
		private System.Windows.Forms.Button b_setPeriod_PastDay;
		private System.Windows.Forms.PictureBox pic_event_photo;
		private System.Windows.Forms.BindingSource systemUsersBindingSource;
		private Access_control_in_OneWireTableAdapters.SystemUsersTableAdapter systemUsersTableAdapter;
		private System.Windows.Forms.CheckBox chB_users_hidePass;
		private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordHasheDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordSaltDataGridViewTextBoxColumn;
	}
}