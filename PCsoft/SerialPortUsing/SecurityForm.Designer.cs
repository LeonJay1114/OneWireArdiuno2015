namespace SerialPortUsing {
	partial class SecurityForm {
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
			this.pic_face = new System.Windows.Forms.PictureBox();
			this.l1 = new System.Windows.Forms.Label();
			this.l_fio = new System.Windows.Forms.Label();
			this.cB_testButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pic_face)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_face
			// 
			this.pic_face.Location = new System.Drawing.Point(353, 12);
			this.pic_face.Name = "pic_face";
			this.pic_face.Size = new System.Drawing.Size(600, 800);
			this.pic_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pic_face.TabIndex = 0;
			this.pic_face.TabStop = false;
			// 
			// l1
			// 
			this.l1.AutoSize = true;
			this.l1.Location = new System.Drawing.Point(303, 816);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(34, 13);
			this.l1.TabIndex = 1;
			this.l1.Text = "ФИО";
			// 
			// l_fio
			// 
			this.l_fio.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_fio.Location = new System.Drawing.Point(343, 816);
			this.l_fio.Name = "l_fio";
			this.l_fio.Size = new System.Drawing.Size(610, 100);
			this.l_fio.TabIndex = 2;
			this.l_fio.Text = "ФИО";
			// 
			// cB_testButton
			// 
			this.cB_testButton.Location = new System.Drawing.Point(12, 893);
			this.cB_testButton.Name = "cB_testButton";
			this.cB_testButton.Size = new System.Drawing.Size(75, 23);
			this.cB_testButton.TabIndex = 3;
			this.cB_testButton.Text = "Test";
			this.cB_testButton.UseVisualStyleBackColor = true;
			this.cB_testButton.Click += new System.EventHandler(this.cB_testButton_Click);
			// 
			// SecurityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(965, 925);
			this.Controls.Add(this.cB_testButton);
			this.Controls.Add(this.l_fio);
			this.Controls.Add(this.l1);
			this.Controls.Add(this.pic_face);
			this.Name = "SecurityForm";
			this.Text = "SecurityForm";
			((System.ComponentModel.ISupportInitialize)(this.pic_face)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_face;
		private System.Windows.Forms.Label l1;
		private System.Windows.Forms.Label l_fio;
		private System.Windows.Forms.Button cB_testButton;
	}
}