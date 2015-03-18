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
			this.l_action = new System.Windows.Forms.Label();
			this.l_actionTime = new System.Windows.Forms.Label();
			this.l_NotInTime = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic_face)).BeginInit();
			this.SuspendLayout();
			// 
			// pic_face
			// 
			this.pic_face.BackColor = System.Drawing.Color.Transparent;
			this.pic_face.Location = new System.Drawing.Point(373, 61);
			this.pic_face.Name = "pic_face";
			this.pic_face.Size = new System.Drawing.Size(300, 431);
			this.pic_face.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic_face.TabIndex = 0;
			this.pic_face.TabStop = false;
			// 
			// l1
			// 
			this.l1.AutoSize = true;
			this.l1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l1.Location = new System.Drawing.Point(124, 483);
			this.l1.Name = "l1";
			this.l1.Size = new System.Drawing.Size(47, 20);
			this.l1.TabIndex = 1;
			this.l1.Text = "ФИО";
			// 
			// l_fio
			// 
			this.l_fio.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_fio.Location = new System.Drawing.Point(118, 505);
			this.l_fio.Name = "l_fio";
			this.l_fio.Size = new System.Drawing.Size(610, 57);
			this.l_fio.TabIndex = 2;
			this.l_fio.Text = "ФИО";
			// 
			// cB_testButton
			// 
			this.cB_testButton.Location = new System.Drawing.Point(12, 533);
			this.cB_testButton.Name = "cB_testButton";
			this.cB_testButton.Size = new System.Drawing.Size(75, 25);
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
			// l_action
			// 
			this.l_action.AutoSize = true;
			this.l_action.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_action.Location = new System.Drawing.Point(445, 9);
			this.l_action.Name = "l_action";
			this.l_action.Size = new System.Drawing.Size(206, 31);
			this.l_action.TabIndex = 14;
			this.l_action.Text = "Входит/Выходит";
			// 
			// l_actionTime
			// 
			this.l_actionTime.AutoSize = true;
			this.l_actionTime.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_actionTime.Location = new System.Drawing.Point(475, 41);
			this.l_actionTime.Name = "l_actionTime";
			this.l_actionTime.Size = new System.Drawing.Size(92, 17);
			this.l_actionTime.TabIndex = 16;
			this.l_actionTime.Text = "Дата и время";
			// 
			// l_NotInTime
			// 
			this.l_NotInTime.AutoSize = true;
			this.l_NotInTime.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.l_NotInTime.ForeColor = System.Drawing.Color.Maroon;
			this.l_NotInTime.Location = new System.Drawing.Point(100, 210);
			this.l_NotInTime.Name = "l_NotInTime";
			this.l_NotInTime.Size = new System.Drawing.Size(249, 21);
			this.l_NotInTime.TabIndex = 17;
			this.l_NotInTime.Text = "Непредвиденное присутствие";
			this.l_NotInTime.Visible = false;
			// 
			// SecurityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 571);
			this.Controls.Add(this.l_NotInTime);
			this.Controls.Add(this.l_actionTime);
			this.Controls.Add(this.pic_face);
			this.Controls.Add(this.l_action);
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
		private System.Windows.Forms.Label l_action;
		private System.Windows.Forms.Label l_actionTime;
		private System.Windows.Forms.Label l_NotInTime;
	}
}