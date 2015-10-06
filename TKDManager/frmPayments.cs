using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKDManager.Helpers;
using TKDManager.Models;

namespace TKDManager
{
	public partial class frmPayments : Form
	{
		public int CurrentClubID { get; set; }
		private Member _selectedMember;

		public frmPayments()
		{
			InitializeComponent();
		}
		#region Events
		private void frmPayments_Load(object sender, EventArgs e)
		{
			ComboBoxHelper.PopulateMonths(cboMonth);
			ComboBoxHelper.PopulateYears(cboYear);
			ComboBoxHelper.SelectCurrentPeriod(cboMonth, cboYear);

			cboMonth.SelectedIndexChanged += cboMonth_SelectedIndexChanged;
			cboYear.SelectedIndexChanged += cboYear_SelectedIndexChanged;

			FillGrids();
		}

		private void grdUnPaid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			AmountCellFormating(grdUnPaid, e);
		}

		private void grdPaid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			AmountCellFormating(grdPaid, e);
		}

		private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
			FillGrids();
		}

		private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			FillGrids();
		}

		private void grdUnPaid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SortOrder order = SortOrder.Descending;

			string columnName = grdUnPaid.Columns[e.ColumnIndex].DataPropertyName;

			if (grdUnPaid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
			{
				order = SortOrder.Ascending;
			}
			
			FillUnPaidGrid(columnName, order);
		}

		private void grdPaid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SortOrder order = SortOrder.Descending;

			string columnName = grdPaid.Columns[e.ColumnIndex].DataPropertyName;

			if (grdPaid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
			{
				order = SortOrder.Ascending;
			}
			
			FillPaidGrid(columnName, order);
		}

		private void btnMoveRight_Click(object sender, EventArgs e)
		{
			var context = new TKDManagerEntities();
			int selectedPeriod = Convert.ToInt32(cboYear.SelectedValue) * 100 + Convert.ToInt32(cboMonth.SelectedValue);

			foreach (DataGridViewRow selectedRow in grdUnPaid.SelectedRows)
			{
				int currentMemberID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

					var bills = from bill in context.Bill
								where bill.MemberID == currentMemberID
								&& bill.DueDate.Year * 100 + bill.DueDate.Month == selectedPeriod
								select bill;

					if (bills.Any())
					{
						bills.First().PaidDate = DateTime.Now.Date;
						context.SaveChanges();
					}
			}
			FillGrids();
		}

		private void btnMoveLeft_Click(object sender, EventArgs e)
		{
			var context = new TKDManagerEntities();
			int selectedPeriod = Convert.ToInt32(cboYear.SelectedValue) * 100 + Convert.ToInt32(cboMonth.SelectedValue);

			foreach (DataGridViewRow selectedRow in grdPaid.SelectedRows)
			{
				int currentMemberID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

					var bills = from bill in context.Bill
								where bill.MemberID == currentMemberID
								&& bill.DueDate.Year * 100 + bill.DueDate.Month == selectedPeriod
								select bill;

					if (bills.Any())
					{
						bills.First().PaidDate = new DateTime(1, 1, 1);
						context.SaveChanges();
					}
			}
			FillGrids();
		}

		#endregion

		#region Private methods
		private void FillGrids()
		{
			FillUnPaidGrid("MemberID", SortOrder.Descending);
			FillPaidGrid("MemberID", SortOrder.Descending);			
		}

		private void FillUnPaidGrid(string column, SortOrder order)
		{
			if (cboYear.SelectedValue != null && cboYear.SelectedValue != null)
			{ 
				int selectedPeriod = Convert.ToInt32(cboYear.SelectedValue) * 100 + Convert.ToInt32(cboMonth.SelectedValue);
			
				var context = new TKDManagerEntities();

				var unpaid = from member in context.Member
								join bill in context.Bill on member.MemberID equals bill.MemberID 
								where member.ClubID == CurrentClubID
								&& bill.DueDate.Year * 100 + bill.DueDate.Month == selectedPeriod
								&& bill.PaidDate < new DateTime(1900, 1, 1)
								select new PaymentMember 
									{ MemberID = member.MemberID
									, FirstName = member.FirstName
									, LastName = member.LastName
									, Amount = bill.Amount
									};

				var param = column;    
				var pi = typeof(PaymentMember).GetProperty(param);
				var orderedMembers = order == SortOrder.Descending ? unpaid.ToList().OrderBy(x => pi.GetValue(x, null)) : unpaid.ToList().OrderByDescending(x => pi.GetValue(x, null));

				grdUnPaid.DataSource = orderedMembers.ToList();

				DataGridViewHelper.SetSimpleMemberColumnName(grdUnPaid);

				grdUnPaid.Columns[0].Width = 60;
				grdUnPaid.Columns[1].Width = 110;
				grdUnPaid.Columns[2].Width = 110;
				grdUnPaid.Columns[3].Width = 60;

				var dataGridViewColumn = grdUnPaid.Columns[column];
				if (dataGridViewColumn != null) dataGridViewColumn.HeaderCell.SortGlyphDirection = order;

			}
		}
		private void FillPaidGrid(string column, SortOrder order)
		{
			if (cboYear.SelectedValue != null && cboYear.SelectedValue != null)
			{ 
				int selectedPeriod = Convert.ToInt32(cboYear.SelectedValue) * 100 + Convert.ToInt32(cboMonth.SelectedValue);
			
				var context = new TKDManagerEntities();

				var paid = from member in context.Member
								join bill in context.Bill on member.MemberID equals bill.MemberID 
								where member.ClubID == CurrentClubID
								&& bill.DueDate.Year * 100 + bill.DueDate.Month == selectedPeriod
								&& bill.PaidDate > new DateTime(1900, 1, 1)
								select new PaymentMember 
									{ MemberID = member.MemberID
									, FirstName = member.FirstName
									, LastName = member.LastName
									, Amount = bill.Amount
									};

				var param = column;    
				var pi = typeof(PaymentMember).GetProperty(param);
				var orderedMembers = order == SortOrder.Descending ? paid.ToList().OrderBy(x => pi.GetValue(x, null)) : paid.ToList().OrderByDescending(x => pi.GetValue(x, null));

				grdPaid.DataSource = orderedMembers.ToList();

				DataGridViewHelper.SetSimpleMemberColumnName(grdPaid);

				grdPaid.Columns[0].Width = 60;
				grdPaid.Columns[1].Width = 110;
				grdPaid.Columns[2].Width = 110;
				grdPaid.Columns[3].Width = 60;			

				var dataGridViewColumn = grdPaid.Columns[column];
				if (dataGridViewColumn != null) dataGridViewColumn.HeaderCell.SortGlyphDirection = order;
			}
		}

		private void AmountCellFormating(DataGridView grd, DataGridViewCellFormattingEventArgs e)
		{
			if (grd.Columns[e.ColumnIndex].Name.Equals("Amount"))
			{
				e.Value = string.Format("CHF {0}.-", e.Value);
			}			
		}
		#endregion



	}
}
