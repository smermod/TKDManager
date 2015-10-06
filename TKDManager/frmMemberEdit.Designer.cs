namespace TKDManager
{
	partial class frmMemberEdit
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
			this.btnSave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtResponsiblePerson = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.cboFee = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBelt = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMobilePhoneNb = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtHomePhoneNb = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTown = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNPA = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAddress1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboGender = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMemberID = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSaveAndClose = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cboLicensePaidUntil = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(196, 429);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(76, 30);
			this.btnSave.TabIndex = 5;
			this.btnSave.Text = "Sauver";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cboLicensePaidUntil);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtResponsiblePerson);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.cboFee);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.cboBelt);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.dtpEntryDate);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.txtMobilePhoneNb);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtHomePhoneNb);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtTown);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtNPA);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtAddress1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cboGender);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dtpBirthDate);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtLastName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtMemberID);
			this.groupBox1.Location = new System.Drawing.Point(9, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 420);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 13);
			this.label10.TabIndex = 40;
			this.label10.Text = "Nom pers. responsable:";
			// 
			// txtResponsiblePerson
			// 
			this.txtResponsiblePerson.Location = new System.Drawing.Point(139, 94);
			this.txtResponsiblePerson.Name = "txtResponsiblePerson";
			this.txtResponsiblePerson.Size = new System.Drawing.Size(257, 20);
			this.txtResponsiblePerson.TabIndex = 39;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 386);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 13);
			this.label7.TabIndex = 38;
			this.label7.Text = "Licence payée pour:";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(10, 359);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 13);
			this.label16.TabIndex = 36;
			this.label16.Text = "Cotisation:";
			// 
			// cboFee
			// 
			this.cboFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFee.FormattingEnabled = true;
			this.cboFee.Location = new System.Drawing.Point(139, 356);
			this.cboFee.Name = "cboFee";
			this.cboFee.Size = new System.Drawing.Size(162, 21);
			this.cboFee.TabIndex = 35;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(10, 332);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(39, 13);
			this.label15.TabIndex = 34;
			this.label15.Text = "Grade:";
			// 
			// cboBelt
			// 
			this.cboBelt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBelt.FormattingEnabled = true;
			this.cboBelt.Location = new System.Drawing.Point(139, 329);
			this.cboBelt.Name = "cboBelt";
			this.cboBelt.Size = new System.Drawing.Size(162, 21);
			this.cboBelt.TabIndex = 33;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(10, 306);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 13);
			this.label14.TabIndex = 32;
			this.label14.Text = "Date d\'entrée:";
			// 
			// dtpEntryDate
			// 
			this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEntryDate.Location = new System.Drawing.Point(139, 303);
			this.dtpEntryDate.Name = "dtpEntryDate";
			this.dtpEntryDate.Size = new System.Drawing.Size(97, 20);
			this.dtpEntryDate.TabIndex = 31;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(10, 280);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(61, 13);
			this.label13.TabIndex = 30;
			this.label13.Text = "Tél. mobile:";
			// 
			// txtMobilePhoneNb
			// 
			this.txtMobilePhoneNb.Location = new System.Drawing.Point(139, 277);
			this.txtMobilePhoneNb.Name = "txtMobilePhoneNb";
			this.txtMobilePhoneNb.Size = new System.Drawing.Size(162, 20);
			this.txtMobilePhoneNb.TabIndex = 29;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 254);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 13);
			this.label11.TabIndex = 26;
			this.label11.Text = "Tél. fixe:";
			// 
			// txtHomePhoneNb
			// 
			this.txtHomePhoneNb.Location = new System.Drawing.Point(139, 251);
			this.txtHomePhoneNb.Name = "txtHomePhoneNb";
			this.txtHomePhoneNb.Size = new System.Drawing.Size(162, 20);
			this.txtHomePhoneNb.TabIndex = 25;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 228);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(47, 13);
			this.label9.TabIndex = 22;
			this.label9.Text = "Localité:";
			// 
			// txtTown
			// 
			this.txtTown.Location = new System.Drawing.Point(139, 225);
			this.txtTown.Name = "txtTown";
			this.txtTown.Size = new System.Drawing.Size(162, 20);
			this.txtTown.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 202);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 13);
			this.label8.TabIndex = 20;
			this.label8.Text = "NPA:";
			// 
			// txtNPA
			// 
			this.txtNPA.Location = new System.Drawing.Point(139, 199);
			this.txtNPA.Name = "txtNPA";
			this.txtNPA.Size = new System.Drawing.Size(97, 20);
			this.txtNPA.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Adresse:";
			// 
			// txtAddress1
			// 
			this.txtAddress1.Location = new System.Drawing.Point(139, 173);
			this.txtAddress1.Name = "txtAddress1";
			this.txtAddress1.Size = new System.Drawing.Size(257, 20);
			this.txtAddress1.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Genre:";
			// 
			// cboGender
			// 
			this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboGender.FormattingEnabled = true;
			this.cboGender.Location = new System.Drawing.Point(139, 146);
			this.cboGender.Name = "cboGender";
			this.cboGender.Size = new System.Drawing.Size(162, 21);
			this.cboGender.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Date de naiss.:";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(139, 120);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(97, 20);
			this.dtpBirthDate.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nom de famille:";
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(139, 68);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(162, 20);
			this.txtLastName.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Prénom:";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(139, 42);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(162, 20);
			this.txtFirstName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "No de Membre:";
			// 
			// txtMemberID
			// 
			this.txtMemberID.Enabled = false;
			this.txtMemberID.Location = new System.Drawing.Point(139, 16);
			this.txtMemberID.Name = "txtMemberID";
			this.txtMemberID.Size = new System.Drawing.Size(162, 20);
			this.txtMemberID.TabIndex = 3;
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(114, 429);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(76, 30);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "Nouveau";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSaveAndClose
			// 
			this.btnSaveAndClose.Location = new System.Drawing.Point(278, 429);
			this.btnSaveAndClose.Name = "btnSaveAndClose";
			this.btnSaveAndClose.Size = new System.Drawing.Size(136, 30);
			this.btnSaveAndClose.TabIndex = 2;
			this.btnSaveAndClose.Text = "Sauver et Fermer";
			this.btnSaveAndClose.UseVisualStyleBackColor = true;
			this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(9, 429);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(76, 30);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Annuler";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cboLicensePaidUntil
			// 
			this.cboLicensePaidUntil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLicensePaidUntil.FormattingEnabled = true;
			this.cboLicensePaidUntil.Location = new System.Drawing.Point(139, 383);
			this.cboLicensePaidUntil.Name = "cboLicensePaidUntil";
			this.cboLicensePaidUntil.Size = new System.Drawing.Size(97, 21);
			this.cboLicensePaidUntil.TabIndex = 41;
			// 
			// frmMemberEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(423, 467);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSaveAndClose);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMemberEdit";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ajouter/Editer un membre";
			this.Load += new System.EventHandler(this.frmMemberEdit_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMemberID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboGender;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ComboBox cboFee;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBelt;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker dtpEntryDate;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMobilePhoneNb;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtHomePhoneNb;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTown;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNPA;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddress1;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnSaveAndClose;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtResponsiblePerson;
		private System.Windows.Forms.ComboBox cboLicensePaidUntil;
	}
}