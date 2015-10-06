using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKDManager.ConfigSections;
using TKDManager.Helpers;
using TKDManager.Models;

namespace TKDManager
{
	public partial class frmPrintDiploma : Form
	{
		public int CurrentClubID { get; set; }
		private Member _selectedMember;

		public frmPrintDiploma()
		{
			InitializeComponent();
		}
		#region Events
		private void frmPrintDiploma_Load(object sender, EventArgs e)
		{
			ComboBoxHelper.LoadBelts(cboBeltFrom, false, "BeltKeup");
			dtpDate.Value = DateTime.Now;

			FillGrid("MemberID", SortOrder.Descending);
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
		
		private void btnPrint_Click(object sender, EventArgs e)
		{
			PrintDiploma();
		}

		private void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
			PrintPage(e);
		}

		#endregion

		#region Private methods
		private void FillGrid(string column, SortOrder order)
		{
			var context = new TKDManagerEntities();

			var members = from member in context.Member
							where member.ClubID == CurrentClubID
							select new SimpleMember {MemberID = member.MemberID, FirstName = member.FirstName, LastName = member.LastName};

			var param = column;    
			var pi = typeof(SimpleMember).GetProperty(param);
			var orderedMembers = order == SortOrder.Descending ? members.ToList().OrderBy(x => pi.GetValue(x, null)) : members.ToList().OrderByDescending(x => pi.GetValue(x, null));

			grdMembers.DataSource = orderedMembers.ToList();

			DataGridViewHelper.SetSimpleMemberColumnName(grdMembers);

			grdMembers.Columns[0].Width = 60;
			grdMembers.Columns[1].Width = 140;
			grdMembers.Columns[2].Width = 140;

			var dataGridViewColumn = grdMembers.Columns[column];
			if (dataGridViewColumn != null) dataGridViewColumn.HeaderCell.SortGlyphDirection = order;
		}

		private void PrintDiploma()
		{
			var context = new TKDManagerEntities();

            PrintDialog pd = new PrintDialog();
            PrintDocument pdoc = new PrintDocument();
			DialogResult result;

			pdoc.PrintPage += pdoc_PrintPage;

            result = pd.ShowDialog();

            if (result == DialogResult.OK)
            {
				// Normally there should be only one cf the grid settings			
				foreach (DataGridViewRow selectedRow in grdMembers.SelectedRows)
				{
					int currentMemberID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

					_selectedMember = context.Member.First(m => m.MemberID == currentMemberID);
				
					pdoc.PrinterSettings = pd.PrinterSettings;
					pdoc.Print();

				}
			}
		}

		private void PrintPage(PrintPageEventArgs e)
		{
			PrintCoordinatesSection config = (PrintCoordinatesSection)ConfigurationManager.GetSection("PrintCoordinates");
			int largeFontSize = int.Parse(ConfigurationManager.AppSettings["DiplLargeFontSize"]);
			int smallFontSize = int.Parse(ConfigurationManager.AppSettings["DiplSmallFontSize"]);
			float x = config.Instances["DiplNameCoordinates"].X;
			float y = config.Instances["DiplNameCoordinates"].Y;

			var			context		= new TKDManagerEntities();
            Graphics	graphics	= e.Graphics;
            Font		font		= new Font("Arial Narrow", largeFontSize, FontStyle.Regular);
			SolidBrush	brush		= new SolidBrush(Color.Black);

			string		keupFrom	= cboBeltFrom.SelectedValue.ToString();			
			string		beltFrom	= cboBeltFrom.Text;

			graphics.DrawString(_selectedMember.FirstName + " " + _selectedMember.LastName, font, brush, x, y);
			
			x = config.Instances["DiplBirthDateCoordinates"].X;
			y = config.Instances["DiplBirthDateCoordinates"].Y;
			if (_selectedMember.BirthDate != null)
				graphics.DrawString(_selectedMember.BirthDate.Value.ToShortDateString(), font, brush, x, y);

			x = config.Instances["DiplKeupCoordinates"].X;
			y = config.Instances["DiplKeupCoordinates"].Y;
			graphics.DrawString(keupFrom, font, brush, x, y);

			x = config.Instances["DiplBeltCoordinates"].X;
			y = config.Instances["DiplBeltCoordinates"].Y;
			graphics.DrawString(beltFrom, font, brush, x, y);

			font		= new Font("Arial Narrow", smallFontSize, FontStyle.Regular);
			x = config.Instances["DiplDateCoordinates"].X;
			y = config.Instances["DiplDateCoordinates"].Y;
			graphics.DrawString(dtpDate.Value.ToShortDateString(), font, brush, x, y);

        }
		#endregion

	}
}
