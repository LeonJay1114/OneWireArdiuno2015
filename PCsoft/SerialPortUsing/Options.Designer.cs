namespace SerialPortUsing
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_speed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ComPort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_dbpath = new System.Windows.Forms.TextBox();
            this.b_saveConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cb_speed.Location = new System.Drawing.Point(151, 12);
            this.cb_speed.Name = "cb_speed";
            this.cb_speed.Size = new System.Drawing.Size(121, 21);
            this.cb_speed.TabIndex = 0;
            this.cb_speed.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Скорость bps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Com port";
            // 
            // cb_ComPort
            // 
            this.cb_ComPort.FormattingEnabled = true;
            this.cb_ComPort.Location = new System.Drawing.Point(151, 44);
            this.cb_ComPort.Name = "cb_ComPort";
            this.cb_ComPort.Size = new System.Drawing.Size(121, 21);
            this.cb_ComPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DB file path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "access|*.accdb";
            // 
            // tb_dbpath
            // 
            this.tb_dbpath.Location = new System.Drawing.Point(151, 72);
            this.tb_dbpath.Name = "tb_dbpath";
            this.tb_dbpath.Size = new System.Drawing.Size(121, 20);
            this.tb_dbpath.TabIndex = 5;
            this.tb_dbpath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_dbpath_MouseDoubleClick);
            // 
            // b_saveConfig
            // 
            this.b_saveConfig.Location = new System.Drawing.Point(106, 98);
            this.b_saveConfig.Name = "b_saveConfig";
            this.b_saveConfig.Size = new System.Drawing.Size(75, 23);
            this.b_saveConfig.TabIndex = 6;
            this.b_saveConfig.Text = "Save";
            this.b_saveConfig.UseVisualStyleBackColor = true;
            this.b_saveConfig.Click += new System.EventHandler(this.b_saveConfig_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 137);
            this.Controls.Add(this.b_saveConfig);
            this.Controls.Add(this.tb_dbpath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ComPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_speed);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ComPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tb_dbpath;
        private System.Windows.Forms.Button b_saveConfig;

    }
}