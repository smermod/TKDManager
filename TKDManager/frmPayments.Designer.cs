namespace TKDManager
{
	partial class frmPayments
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboYear = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboMonth = new System.Windows.Forms.ComboBox();
			this.grdUnPaid = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grdPaid = new System.Windows.Forms.DataGridView();
			this.btnMoveRight = new System.Windows.Forms.Button();
			this.btnMoveLeft = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdUnPaid)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPaid)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cboYear);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cboMonth);
			this.groupBox1.Controls.Add(this.grdUnPaid);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(431, 638);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Factures non payée";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(178, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "Année:";
			// 
			// cboYear
			// 
			this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboYear.FormattingEnabled = true;
			this.cboYear.Location = new System.Drawing.Point(225, 25);
			this.cboYear.Name = "cboYear";
			this.cboYear.Size = new System.Drawing.Size(72, 21);
			this.cboYear.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "Mois:";
			// 
			// cboMonth
			// 
			this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMonth.FormattingEnabled = true;
			this.cboMonth.Location = new System.Drawing.Point(54, 25);
			this.cboMonth.Name = "cboMonth";
			this.cboMonth.Size = new System.Drawing.Size(121, 21);
			this.cboMonth.TabIndex = 24;
			// 
			// grdUnPaid
			// 
			this.grdUnPaid.AllowUserToAddRows = false;
			this.grdUnPaid.AllowUserToDeleteRows = false;
			this.grdUnPaid.AllowUserToResizeColumns = false;
			this.grdUnPaid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
			this.grdUnPaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grdUnPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdUnPaid.Location = new System.Drawing.Point(16, 60);
			this.grdUnPaid.Name = "grdUnPaid";
			this.grdUnPaid.ReadOnly = true;
			this.grdUnPaid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grdUnPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdUnPaid.Size = new System.Drawing.Size(400, 561);
			this.grdUnPaid.TabIndex = 22;
			this.grdUnPaid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdUnPaid_CellFormatting);
			this.grdUnPaid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdUnPaid_ColumnHeaderMouseClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.grdPaid);
			this.groupBox2.Location = new System.Drawing.Point(484, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(429, 638);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Factures payée";
			// 
			// grdPaid
			// 
			this.grdPaid.AllowUserToAddRows = false;
			this.grdPaid.AllowUserToDeleteRows = false;
			this.grdPaid.AllowUserToResizeColumns = false;
			this.grdPaid.AllowUserToResizeRows = false;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
			this.grdPaid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.grdPaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPaid.Location = new System.Drawing.Point(15, 60);
			this.grdPaid.Name = "grdPaid";
			this.grdPaid.ReadOnly = true;
			this.grdPaid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.grdPaid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPaid.Size = new System.Drawing.Size(400, 561);
			this.grdPaid.TabIndex = 22;
			this.grdPaid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPaid_CellFormatting);
			this.grdPaid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdPaid_ColumnHeaderMouseClick);
			// 
			// btnMoveRight
			// 
			this.btnMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoveRight.Location = new System.Drawing.Point(449, 287);
			this.btnMoveRight.Name = "btnMoveRight";
			this.btnMoveRight.Size = new System.Drawing.Size(28, 28);
			this.btnMoveRight.TabIndex = 2;
			this.btnMoveRight.Text = ">";
			this.btnMoveRight.UseVisualStyleBackColor = true;
			this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
			// 
			// btnMoveLeft
			// 
			this.btnMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMoveLeft.Location = new System.Drawing.Point(449, 321);
			this.btnMoveLeft.Name = "btnMoveLeft";
			this.btnMoveLeft.Size = new System.Drawing.Size(28, 28);
			this.btnMoveLeft.TabIndex = 3;
			this.btnMoveLeft.Text = "<";
			this.btnMoveLeft.UseVisualStyleBackColor = true;
			this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
			// 
			// frmPayments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 662);
			this.Controls.Add(this.btnMoveLeft);
			this.Controls.Add(this.btnMoveRight);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmPayments";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Paiements";
			this.Load += new System.EventHandler(this.frmPayments_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdUnPaid)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdPaid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grdUnPaid;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView grdPaid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboYear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboMonth;
		private System.Windows.Forms.Button btnMoveRight;
		private System.Windows.Forms.Button btnMoveLeft;
	}
}