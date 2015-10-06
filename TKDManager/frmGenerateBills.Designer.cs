namespace TKDManager
{
	partial class frmGenerateBills
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.grdMembers = new System.Windows.Forms.DataGridView();
			this.btnGenerateAndPrint = new System.Windows.Forms.Button();
			this.txtMessage = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboMonth = new System.Windows.Forms.ComboBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// grdMembers
			// 
			this.grdMembers.AllowUserToAddRows = false;
			this.grdMembers.AllowUserToDeleteRows = false;
			this.grdMembers.AllowUserToResizeColumns = false;
			this.grdMembers.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
			this.grdMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMembers.Location = new System.Drawing.Point(12, 48);
			this.grdMembers.Name = "grdMembers";
			this.grdMembers.ReadOnly = true;
			this.grdMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grdMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdMembers.Size = new System.Drawing.Size(400, 450);
			this.grdMembers.TabIndex = 0;
			this.grdMembers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMembers_ColumnHeaderMouseClick);
			// 
			// btnGenerateAndPrint
			// 
			this.btnGenerateAndPrint.Location = new System.Drawing.Point(276, 620);
			this.btnGenerateAndPrint.Name = "btnGenerateAndPrint";
			this.btnGenerateAndPrint.Size = new System.Drawing.Size(136, 30);
			this.btnGenerateAndPrint.TabIndex = 19;
			this.btnGenerateAndPrint.Text = "Générer et imprimer";
			this.btnGenerateAndPrint.UseVisualStyleBackColor = true;
			this.btnGenerateAndPrint.Click += new System.EventHandler(this.btnGenerateAndPrint_Click);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(12, 513);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(400, 96);
			this.txtMessage.TabIndex = 22;
			this.txtMessage.Text = "Acquitté avec remerciements:\nCotisations mois de:\nDobok\nLicence et frais administ" +
    "ratifs";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 32;
			this.label1.Text = "Année:";
			// 
			// cboYear
			// 
			this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboYear.FormattingEnabled = true;
			this.cboYear.Location = new System.Drawing.Point(221, 16);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(72, 21);
			this.cboYear.TabIndex = 31;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 30;
			this.label5.Text = "Mois:";
			// 
			// cboMonth
			// 
			this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonth.FormattingEnabled = true;
			this.cboMonth.Location = new System.Drawing.Point(50, 16);
			this.cboMonth.Name = "cboMonth";
			this.cboMonth.Size = new System.Drawing.Size(121, 21);
			this.cboMonth.TabIndex = 29;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(134, 620);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(136, 30);
			this.btnGenerate.TabIndex = 33;
			this.btnGenerate.Text = "Générer les factures";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// frmGenerateBills
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 662);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cboYear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cboMonth);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.btnGenerateAndPrint);
			this.Controls.Add(this.grdMembers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGenerateBills";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Emission des factures";
			this.Load += new System.EventHandler(this.frmGenerateBills_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdMembers;
		private System.Windows.Forms.Button btnGenerateAndPrint;
		private System.Windows.Forms.RichTextBox txtMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboMonth;
		private System.Windows.Forms.Button btnGenerate;

	}
}