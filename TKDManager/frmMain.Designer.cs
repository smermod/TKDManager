namespace TKDManager
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.lblClubs = new System.Windows.Forms.ToolStripLabel();
			this.cboClubs = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnNew = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnPrintGrid = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.btnBills = new System.Windows.Forms.ToolStripButton();
			this.btnPayments = new System.Windows.Forms.ToolStripButton();
			this.btnDiploma = new System.Windows.Forms.ToolStripButton();
			this.grdMembers = new System.Windows.Forms.DataGridView();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblClubs,
            this.cboClubs,
            this.toolStripSeparator1,
            this.btnNew,
            this.btnDelete,
            this.btnPrintGrid,
            this.toolStripSeparator,
            this.btnBills,
            this.btnPayments,
            this.btnDiploma});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip.Size = new System.Drawing.Size(1264, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip1";
			// 
			// lblClubs
			// 
			this.lblClubs.Name = "lblClubs";
			this.lblClubs.Size = new System.Drawing.Size(41, 22);
			this.lblClubs.Text = "Club : ";
			// 
			// cboClubs
			// 
			this.cboClubs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboClubs.Name = "cboClubs";
			this.cboClubs.Size = new System.Drawing.Size(200, 25);
			this.cboClubs.SelectedIndexChanged += new System.EventHandler(this.cboClubs_SelectedIndexChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnNew
			// 
			this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
			this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(23, 22);
			this.btnNew.Text = "Nouveau";
			this.btnNew.ToolTipText = "Nouveau";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(23, 22);
			this.btnDelete.Text = "Supprimer";
			this.btnDelete.ToolTipText = "Supprimer";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnPrintGrid
			// 
			this.btnPrintGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPrintGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintGrid.Image")));
			this.btnPrintGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrintGrid.Name = "btnPrintGrid";
			this.btnPrintGrid.Size = new System.Drawing.Size(23, 22);
			this.btnPrintGrid.Text = "Imprimer";
			this.btnPrintGrid.ToolTipText = "Imprimer";
			this.btnPrintGrid.Click += new System.EventHandler(this.btnPrintGrid_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// btnBills
			// 
			this.btnBills.Image = ((System.Drawing.Image)(resources.GetObject("btnBills.Image")));
			this.btnBills.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBills.Name = "btnBills";
			this.btnBills.Size = new System.Drawing.Size(71, 22);
			this.btnBills.Text = "Factures";
			this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
			// 
			// btnPayments
			// 
			this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
			this.btnPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPayments.Name = "btnPayments";
			this.btnPayments.Size = new System.Drawing.Size(82, 22);
			this.btnPayments.Text = "Paiements";
			this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
			// 
			// btnDiploma
			// 
			this.btnDiploma.Image = ((System.Drawing.Image)(resources.GetObject("btnDiploma.Image")));
			this.btnDiploma.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDiploma.Name = "btnDiploma";
			this.btnDiploma.Size = new System.Drawing.Size(77, 22);
			this.btnDiploma.Text = "Diplomes";
			this.btnDiploma.Click += new System.EventHandler(this.btnDiploma_Click);
			// 
			// grdMembers
			// 
			this.grdMembers.AllowUserToAddRows = false;
			this.grdMembers.AllowUserToOrderColumns = true;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
			this.grdMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grdMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdMembers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdMembers.Location = new System.Drawing.Point(0, 25);
			this.grdMembers.MultiSelect = false;
			this.grdMembers.Name = "grdMembers";
			this.grdMembers.ReadOnly = true;
			this.grdMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdMembers.Size = new System.Drawing.Size(1264, 657);
			this.grdMembers.TabIndex = 1;
			this.grdMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMembers_CellDoubleClick);
			this.grdMembers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdMembers_CellFormatting);
			this.grdMembers.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMembers_ColumnHeaderMouseClick);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 682);
			this.Controls.Add(this.grdMembers);
			this.Controls.Add(this.toolStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TKD Clubs Manager v. 2015.10.06";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel lblClubs;
		private System.Windows.Forms.ToolStripComboBox cboClubs;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnNew;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnPrintGrid;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripButton btnBills;
		private System.Windows.Forms.ToolStripButton btnPayments;
		private System.Windows.Forms.ToolStripButton btnDiploma;
		private System.Windows.Forms.DataGridView grdMembers;
	}
}