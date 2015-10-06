using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKDManager.Helpers;
using TKDManager.Models;
using DGVPrinterHelper;

namespace TKDManager
{
	public partial class frmMain : Form
	{
		private int CurrentClubID { get; set; }

		public frmMain()
		{
			InitializeComponent();
		}
		#region Events
		private void frmMain_Load(object sender, EventArgs e)
		{

			FillClubList(); 
			if (cboClubs.Items.Count > 1) cboClubs.SelectedIndex = 0;

		}

		private void cboClubs_SelectedIndexChanged(object sender, EventArgs e)
		{
			FillGrid("MemberID", SortOrder.Descending);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
            int currentMemberID  = Convert.ToInt32(grdMembers.SelectedRows[0].Cells[0].Value);

			if (MessageBox.Show(string.Format("Supprimer définitivement le membre no: {0}?", grdMembers.SelectedRows[0].Cells[0].Value), "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            	var context = new TKDManagerEntities();
				Member member = context.Member.First(m => m.MemberID == currentMemberID);
				context.Member.Remove(member);
				context.SaveChanges();
				RefreshGrid(-1);
            }
		}

		private void grdMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{ 
				ShowMemberDetailDialog(Convert.ToInt32(grdMembers.Rows[e.RowIndex].Cells[0].Value));
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ShowMemberDetailDialog(-1);
		}

		private void grdMembers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value == null) return;
			if (e.Value.ToString() == grdMembers.Columns[e.ColumnIndex].Name) return;
			try
			{

				if (grdMembers.Columns[e.ColumnIndex].Name.Equals("Gender"))
				{
					e.Value = DataGridViewHelper.SetGenderLookup(e.Value.ToString());
				}
				else if (grdMembers.Columns[e.ColumnIndex].Name.Equals("BeltID"))
				{
					e.Value = DataGridViewHelper.SetBeltLookup(e.Value.ToString());
				}
			}
			catch (Exception)
			{
				
			}
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			frmGenerateBills generateBills = new frmGenerateBills();
			
			generateBills.CurrentClubID = CurrentClubID;

			generateBills.ShowDialog(this);	
		}

		private void btnPayments_Click(object sender, EventArgs e)
		{
			frmPayments payments = new frmPayments();

			payments.CurrentClubID = CurrentClubID;

			payments.ShowDialog(this);
		}

		private void grdMembers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SortOrder order = SortOrder.Descending;

			string columnName = grdMembers.Columns[e.ColumnIndex].DataPropertyName;

			if (grdMembers.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
			{
				order = SortOrder.Ascending;
			}
			
			FillGrid(columnName, order);
		}

		private void btnDiploma_Click(object sender, EventArgs e)
		{
			frmPrintDiploma printDiploma = new frmPrintDiploma();
			
			printDiploma.CurrentClubID = CurrentClubID;

			printDiploma.ShowDialog(this);			
		}

		private void btnPrintGrid_Click(object sender, EventArgs e)
		{
			DGVPrinter printer = new DGVPrinter();

			printer.Title = cboClubs.Text + " - Liste des membres";
			printer.SubTitle = string.Empty;
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
			printer.PageNumbers = true;
			printer.PageSettings.Landscape = true;
			printer.PageNumberInHeader = false;
			printer.PorportionalColumns = true;
			printer.HeaderCellAlignment = StringAlignment.Near;
			printer.Footer = string.Empty;
			printer.FooterSpacing = 15;
			printer.PrintDataGridView(grdMembers);            
		
		}
		#endregion

		#region Private methods
		private void FillClubList()
		{
			var context = new TKDManagerEntities();

			var clubs = from club in context.Club
						orderby club.ClubID
						select club;

			foreach (var club in clubs)
			{
				cboClubs.Items.Add(club.ClubID + " - " + club.ClubName);
			}
			
		}

		private void FillGrid(string column, SortOrder order)
		{
			var context = new TKDManagerEntities();

			CurrentClubID = StringHelper.GetClubNumberFromConcat(cboClubs.SelectedItem.ToString());

			var members = from member in context.Member
							where member.ClubID == CurrentClubID
							select member;

			var param = column;    
			var pi = typeof(Member).GetProperty(param);
			var orderedMembers = order == SortOrder.Descending ? members.ToList().OrderBy(x => pi.GetValue(x, null)) : members.ToList().OrderByDescending(x => pi.GetValue(x, null));

			grdMembers.DataSource = orderedMembers.ToList();

			DataGridViewHelper.SetMainColumnName(grdMembers);
			
			grdMembers.Columns[6].Visible = false;
			grdMembers.Columns[9].Visible = false;
			grdMembers.Columns[11].Visible = false;
			grdMembers.Columns[14].Visible = false;
			grdMembers.Columns[16].Visible = false;
			grdMembers.Columns[17].Visible = false;

			var dataGridViewColumn = grdMembers.Columns[column];
			if (dataGridViewColumn != null) dataGridViewColumn.HeaderCell.SortGlyphDirection = order;
		}

		public void RefreshGrid(int lastMemberSelected)
		{
			FillGrid("MemberID", SortOrder.Descending);
			if (lastMemberSelected > -1)
			{ 
				int rowIndex = -1;

				DataGridViewRow row = grdMembers.Rows
					.Cast<DataGridViewRow>().First(r => r.Cells["MemberID"].Value.Equals(lastMemberSelected));

				rowIndex = row.Index;
				grdMembers.Rows[rowIndex].Selected = true;
				grdMembers.CurrentCell = grdMembers[0, rowIndex];
			}
		}
		
		private void ShowMemberDetailDialog(int memberID)
		{
			frmMemberEdit memberEdit = new frmMemberEdit();
			
			memberEdit.CurrentMemberID = memberID;
			memberEdit.CurrentClubID = CurrentClubID;

			memberEdit.ShowDialog(this);			
		}

		#endregion


	}
}
