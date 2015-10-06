namespace TKDManager
{
	partial class frmPrintDiploma
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.grdMembers = new System.Windows.Forms.DataGridView();
			this.btnPrint = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.cboBeltFrom = new System.Windows.Forms.ComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// grdMembers
			// 
			this.grdMembers.AllowUserToAddRows = false;
			this.grdMembers.AllowUserToDeleteRows = false;
			this.grdMembers.AllowUserToResizeColumns = false;
			this.grdMembers.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
			this.grdMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMembers.Location = new System.Drawing.Point(12, 12);
			this.grdMembers.MultiSelect = false;
			this.grdMembers.Name = "grdMembers";
			this.grdMembers.ReadOnly = true;
			this.grdMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grdMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdMembers.Size = new System.Drawing.Size(400, 517);
			this.grdMembers.TabIndex = 0;
			this.grdMembers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMembers_ColumnHeaderMouseClick);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(276, 620);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(136, 30);
			this.btnPrint.TabIndex = 19;
			this.btnPrint.Text = "Imprimer";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(9, 551);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(39, 13);
			this.label15.TabIndex = 36;
			this.label15.Text = "Grade:";
			// 
			// cboBeltFrom
			// 
			this.cboBeltFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBeltFrom.FormattingEnabled = true;
			this.cboBeltFrom.Location = new System.Drawing.Point(69, 548);
			this.cboBeltFrom.Name = "cboBeltFrom";
			this.cboBeltFrom.Size = new System.Drawing.Size(162, 21);
			this.cboBeltFrom.TabIndex = 35;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(9, 585);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(33, 13);
			this.label14.TabIndex = 40;
			this.label14.Text = "Date:";
			// 
			// dtpDate
			// 
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(69, 582);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(97, 20);
			this.dtpDate.TabIndex = 39;
			// 
			// frmPrintDiploma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 662);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.cboBeltFrom);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.grdMembers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPrintDiploma";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Diplomes";
			this.Load += new System.EventHandler(this.frmPrintDiploma_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdMembers;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cboBeltFrom;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker dtpDate;

	}
}