namespace SerialPortUsing
{
    partial class Authorisation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorisation));
			this.GB_Login = new System.Windows.Forms.GroupBox();
			this.CheckConnection = new System.Windows.Forms.Label();
			this.tB_password = new System.Windows.Forms.TextBox();
			this.tB_username = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Btn_Enter = new System.Windows.Forms.Button();
			this.GB_Login.SuspendLayout();
			this.SuspendLayout();
			// 
			// GB_Login
			// 
			this.GB_Login.Controls.Add(this.CheckConnection);
			this.GB_Login.Controls.Add(this.tB_password);
			this.GB_Login.Controls.Add(this.tB_username);
			this.GB_Login.Controls.Add(this.label2);
			this.GB_Login.Controls.Add(this.label1);
			this.GB_Login.Controls.Add(this.Btn_Enter);
			this.GB_Login.Location = new System.Drawing.Point(14, 2);
			this.GB_Login.Name = "GB_Login";
			this.GB_Login.Size = new System.Drawing.Size(144, 166);
			this.GB_Login.TabIndex = 6;
			this.GB_Login.TabStop = false;
			// 
			// CheckConnection
			// 
			this.CheckConnection.AutoSize = true;
			this.CheckConnection.Location = new System.Drawing.Point(34, 119);
			this.CheckConnection.Name = "CheckConnection";
			this.CheckConnection.Size = new System.Drawing.Size(0, 13);
			this.CheckConnection.TabIndex = 5;
			// 
			// tB_password
			// 
			this.tB_password.Location = new System.Drawing.Point(26, 96);
			this.tB_password.Name = "tB_password";
			this.tB_password.PasswordChar = '*';
			this.tB_password.Size = new System.Drawing.Size(100, 20);
			this.tB_password.TabIndex = 4;
			this.tB_password.Text = "Admin";
			this.tB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_password_KeyDown);
			// 
			// tB_username
			// 
			this.tB_username.Location = new System.Drawing.Point(26, 33);
			this.tB_username.Name = "tB_username";
			this.tB_username.Size = new System.Drawing.Size(100, 20);
			this.tB_username.TabIndex = 3;
			this.tB_username.Text = "Admin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username";
			// 
			// Btn_Enter
			// 
			this.Btn_Enter.Location = new System.Drawing.Point(37, 135);
			this.Btn_Enter.Name = "Btn_Enter";
			this.Btn_Enter.Size = new System.Drawing.Size(75, 23);
			this.Btn_Enter.TabIndex = 0;
			this.Btn_Enter.Text = "Enter";
			this.Btn_Enter.UseVisualStyleBackColor = true;
			this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
			// 
			// Authorisation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(170, 180);
			this.Controls.Add(this.GB_Login);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Authorisation";
			this.Text = "Authentication";
			this.Load += new System.EventHandler(this.Autorization_Load);
			this.GB_Login.ResumeLayout(false);
			this.GB_Login.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.GroupBox GB_Login;
		private System.Windows.Forms.Label CheckConnection;
		private System.Windows.Forms.TextBox tB_password;
		private System.Windows.Forms.TextBox tB_username;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Btn_Enter;

	}
}