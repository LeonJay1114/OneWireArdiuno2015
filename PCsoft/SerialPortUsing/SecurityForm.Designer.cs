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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityForm));
			this.pic_face = new System.Windows.Forms.PictureBox();
			this.l1 = new System.Windows.Forms.Label();
			this.l_fio = new System.Windows.Forms.Label();
			this.cB_testButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.l_number = new System.Windows.Forms.Label();
			this.l_division = new System.Windows.Forms.Label();
			this.l_shedule = new System.Windows.Forms.Label();
			this.l_profession = new System.Windows.Forms.Label();
			this.l_uidType = new System.Windows.Forms.Label();
			this.l_actionTime = new System.Windows.Forms.Label();
			this.l_blocked = new System.Windows.Forms.Label();
			this.pB_notInTime = new System.Windows.Forms.PictureBox();
			this.pB_enter = new System.Windows.Forms.PictureBox();
			this.pB_vihod = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_face)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_notInTime)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_enter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_vihod)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_face
			// 
			this.pic_face.BackColor = System.Drawing.Color.Transparent;
			this.pic_face.Location = new System.Drawing.Point(373, 92);
			this.pic_face.Name = "pic_face";
			this.pic_face.Size = new System.Drawing.Size(300, 400);
			this.pic_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_face.TabIndex = 0;
			this.pic_face.TabStop = false;
			// 
			// l1
			// 
			this.l1.AutoSize = true;
			this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l1.Location = new System.Drawing.Point(18, 483);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(59, 20);
			this.l1.TabIndex = 1;
			this.l1.Text = "Ф.И.О.";
			// 
			// l_fio
			// 
			this.l_fio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.l_fio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.l_fio.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_fio.Location = new System.Drawing.Point(12, 505);
			this.l_fio.Name = "l_fio";
			this.l_fio.Size = new System.Drawing.Size(716, 168);
			this.l_fio.TabIndex = 2;
			this.l_fio.Text = "Ф.И.О.";
			this.l_fio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cB_testButton
			// 
			this.cB_testButton.Location = new System.Drawing.Point(630, 308);
			this.cB_testButton.Name = "cB_testButton";
			this.cB_testButton.Size = new System.Drawing.Size(117, 45);
			this.cB_testButton.TabIndex = 3;
			this.cB_testButton.Text = "Test";
			this.cB_testButton.UseVisualStyleBackColor = true;
			this.cB_testButton.Visible = false;
			this.cB_testButton.Click += new System.EventHandler(this.cB_testButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 294);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Должность";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(11, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(183, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "ТабельныйНомер";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 207);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "График";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(12, 384);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 24);
			this.label5.TabIndex = 8;
			this.label5.Text = "Тип UID";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(12, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(167, 24);
			this.label6.TabIndex = 7;
			this.label6.Text = "Подразделение";
			// 
			// l_number
			// 
			this.l_number.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_number.Location = new System.Drawing.Point(12, 55);
			this.l_number.Name = "l_number";
			this.l_number.Size = new System.Drawing.Size(354, 64);
			this.l_number.TabIndex = 9;
			this.l_number.Text = "Значение";
			// 
			// l_division
			// 
			this.l_division.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_division.Location = new System.Drawing.Point(13, 142);
			this.l_division.Name = "l_division";
			this.l_division.Size = new System.Drawing.Size(354, 64);
			this.l_division.TabIndex = 10;
			this.l_division.Text = "Значение";
			// 
			// l_shedule
			// 
			this.l_shedule.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_shedule.Location = new System.Drawing.Point(13, 231);
			this.l_shedule.Name = "l_shedule";
			this.l_shedule.Size = new System.Drawing.Size(354, 64);
			this.l_shedule.TabIndex = 11;
			this.l_shedule.Text = "Значение";
			// 
			// l_profession
			// 
			this.l_profession.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_profession.Location = new System.Drawing.Point(13, 318);
			this.l_profession.Name = "l_profession";
			this.l_profession.Size = new System.Drawing.Size(354, 64);
			this.l_profession.TabIndex = 12;
			this.l_profession.Text = "Значение";
			// 
			// l_uidType
			// 
			this.l_uidType.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_uidType.Location = new System.Drawing.Point(13, 408);
			this.l_uidType.Name = "l_uidType";
			this.l_uidType.Size = new System.Drawing.Size(354, 64);
			this.l_uidType.TabIndex = 13;
			this.l_uidType.Text = "Значение";
			// 
			// l_actionTime
			// 
			this.l_actionTime.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_actionTime.Location = new System.Drawing.Point(387, 55);
			this.l_actionTime.Name = "l_actionTime";
			this.l_actionTime.Size = new System.Drawing.Size(272, 34);
			this.l_actionTime.TabIndex = 16;
			this.l_actionTime.Text = "Дата и время";
			this.l_actionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// l_blocked
			// 
			this.l_blocked.AutoSize = true;
			this.l_blocked.BackColor = System.Drawing.Color.Firebrick;
			this.l_blocked.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_blocked.ForeColor = System.Drawing.Color.Black;
			this.l_blocked.Location = new System.Drawing.Point(373, 439);
			this.l_blocked.Name = "l_blocked";
			this.l_blocked.Size = new System.Drawing.Size(301, 53);
			this.l_blocked.TabIndex = 18;
			this.l_blocked.Text = "Заблокирован";
			this.l_blocked.Visible = false;
			// 
			// pB_notInTime
			// 
			this.pB_notInTime.Image = ((System.Drawing.Image)(resources.GetObject("pB_notInTime.Image")));
			this.pB_notInTime.Location = new System.Drawing.Point(278, 207);
			this.pB_notInTime.Name = "pB_notInTime";
			this.pB_notInTime.Size = new System.Drawing.Size(67, 64);
			this.pB_notInTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pB_notInTime.TabIndex = 19;
			this.pB_notInTime.TabStop = false;
			this.pB_notInTime.Visible = false;
			// 
			// pB_enter
			// 
			this.pB_enter.Image = ((System.Drawing.Image)(resources.GetObject("pB_enter.Image")));
			this.pB_enter.Location = new System.Drawing.Point(442, 9);
			this.pB_enter.Name = "pB_enter";
			this.pB_enter.Size = new System.Drawing.Size(175, 43);
			this.pB_enter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pB_enter.TabIndex = 20;
			this.pB_enter.TabStop = false;
			this.pB_enter.Visible = false;
			// 
			// pB_vihod
			// 
			this.pB_vihod.Image = ((System.Drawing.Image)(resources.GetObject("pB_vihod.Image")));
			this.pB_vihod.Location = new System.Drawing.Point(442, 9);
			this.pB_vihod.Name = "pB_vihod";
			this.pB_vihod.Size = new System.Drawing.Size(175, 43);
			this.pB_vihod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pB_vihod.TabIndex = 21;
			this.pB_vihod.TabStop = false;
			this.pB_vihod.Visible = false;
			// 
			// SecurityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 682);
			this.Controls.Add(this.pB_vihod);
			this.Controls.Add(this.pB_enter);
			this.Controls.Add(this.pB_notInTime);
			this.Controls.Add(this.l_blocked);
			this.Controls.Add(this.l_actionTime);
			this.Controls.Add(this.pic_face);
			this.Controls.Add(this.l_uidType);
			this.Controls.Add(this.l_profession);
			this.Controls.Add(this.l_shedule);
			this.Controls.Add(this.l_division);
			this.Controls.Add(this.l_number);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cB_testButton);
			this.Controls.Add(this.l_fio);
			this.Controls.Add(this.l1);
			this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SecurityForm";
			this.Text = "SecurityForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecurityForm_FormClosing);
			this.Load += new System.EventHandler(this.SecurityForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic_face)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_notInTime)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_enter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_vihod)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pic_face;
		private System.Windows.Forms.Label l1;
		private System.Windows.Forms.Label l_fio;
		private System.Windows.Forms.Button cB_testButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label l_number;
		private System.Windows.Forms.Label l_division;
		private System.Windows.Forms.Label l_shedule;
		private System.Windows.Forms.Label l_profession;
		private System.Windows.Forms.Label l_uidType;
		private System.Windows.Forms.Label l_actionTime;
		private System.Windows.Forms.Label l_blocked;
		private System.Windows.Forms.PictureBox pB_notInTime;
		private System.Windows.Forms.PictureBox pB_enter;
		private System.Windows.Forms.PictureBox pB_vihod;
	}
}