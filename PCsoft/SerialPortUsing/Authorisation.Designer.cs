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
			this.b_boss = new System.Windows.Forms.Button();
			this.b_security = new System.Windows.Forms.Button();
			this.b_admin = new System.Windows.Forms.Button();
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
			this.GB_Login.Controls.Add(this.b_boss);
			this.GB_Login.Controls.Add(this.b_security);
			this.GB_Login.Controls.Add(this.b_admin);
			this.GB_Login.Controls.Add(this.CheckConnection);
			this.GB_Login.Controls.Add(this.tB_password);
			this.GB_Login.Controls.Add(this.tB_username);
			this.GB_Login.Controls.Add(this.label2);
			this.GB_Login.Controls.Add(this.label1);
			this.GB_Login.Controls.Add(this.Btn_Enter);
			resources.ApplyResources(this.GB_Login, "GB_Login");
			this.GB_Login.Name = "GB_Login";
			this.GB_Login.TabStop = false;
			// 
			// b_boss
			// 
			resources.ApplyResources(this.b_boss, "b_boss");
			this.b_boss.Name = "b_boss";
			this.b_boss.UseVisualStyleBackColor = true;
			this.b_boss.Click += new System.EventHandler(this.b_boss_Click);
			// 
			// b_security
			// 
			resources.ApplyResources(this.b_security, "b_security");
			this.b_security.Name = "b_security";
			this.b_security.UseVisualStyleBackColor = true;
			this.b_security.Click += new System.EventHandler(this.b_security_Click);
			// 
			// b_admin
			// 
			resources.ApplyResources(this.b_admin, "b_admin");
			this.b_admin.Name = "b_admin";
			this.b_admin.UseVisualStyleBackColor = true;
			this.b_admin.Click += new System.EventHandler(this.b_admin_Click);
			// 
			// CheckConnection
			// 
			resources.ApplyResources(this.CheckConnection, "CheckConnection");
			this.CheckConnection.Name = "CheckConnection";
			// 
			// tB_password
			// 
			resources.ApplyResources(this.tB_password, "tB_password");
			this.tB_password.Name = "tB_password";
			this.tB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_password_KeyDown);
			// 
			// tB_username
			// 
			resources.ApplyResources(this.tB_username, "tB_username");
			this.tB_username.Name = "tB_username";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// Btn_Enter
			// 
			resources.ApplyResources(this.Btn_Enter, "Btn_Enter");
			this.Btn_Enter.Name = "Btn_Enter";
			this.Btn_Enter.UseVisualStyleBackColor = true;
			this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
			// 
			// Authorisation
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GB_Login);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Authorisation";
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
		private System.Windows.Forms.Button b_boss;
		private System.Windows.Forms.Button b_security;
		private System.Windows.Forms.Button b_admin;

	}
}