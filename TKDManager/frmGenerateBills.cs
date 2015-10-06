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

namespace TKDManager
{
	public partial class frmGenerateBills : Form
	{
		public int CurrentClubID { get; set; }
		private Member _selectedMember;

		public frmGenerateBills()
		{
			InitializeComponent();
		}
		#region Events
		private void frmGenerateBills_Load(object sender, EventArgs e)
		{
			ComboBoxHelper.PopulateMonths(cboMonth);
			ComboBoxHelper.PopulateYears(cboYear);
			ComboBoxHelper.SelectCurrentPeriod(cboMonth, cboYear);
			
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

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			GenerateBills(false);
		}

		private void btnGenerateAndPrint_Click(object sender, EventArgs e)
		{
			GenerateBills(true);
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

		private void GenerateBills(bool print)
		{
			try
			{

				var context = new TKDManagerEntities();
				DateTime dueDate = new DateTime(Convert.ToInt32(cboYear.SelectedValue), Convert.ToInt32(cboMonth.SelectedValue), 1);
				int selectedPeriod = Convert.ToInt32(cboYear.SelectedValue) * 100 + Convert.ToInt32(cboMonth.SelectedValue);

				PrintDialog pd = new PrintDialog();
				PrintDocument pdoc = new PrintDocument();
				DialogResult result = DialogResult.OK;

				pdoc.PrintPage += pdoc_PrintPage;

				if (print)
				{
					result = pd.ShowDialog();
				}

				if (result == DialogResult.OK)
				{
			
					foreach (DataGridViewRow selectedRow in grdMembers.SelectedRows)
					{
						int currentMemberID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());

						_selectedMember = context.Member.First(m => m.MemberID == currentMemberID);
						Fee fee = context.Fee.First(m => m.FeeID == _selectedMember.FeeID);
				
						var bills = from bill in context.Bill
									where bill.MemberID == currentMemberID
									&& bill.DueDate.Year * 100 + bill.DueDate.Month == selectedPeriod
									select bill;
				
						if (!bills.Any())
						{
							context.Bill.Add(new Bill() { Amount = fee.FeeAmount, MemberID = currentMemberID, DueDate = dueDate });
						}
						else
						{
							bills.First().Amount = fee.FeeAmount;
							bills.First().DueDate = dueDate;
						}
						context.SaveChanges();

						if (print)
						{ 
							pdoc.PrinterSettings = pd.PrinterSettings;
							pdoc.Print();
						}
					}
				}
				MessageBox.Show(this, "Factures générées avec succès.");
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(this, ex.Message);
			}
		}

		private void PrintPage(PrintPageEventArgs e)
		{
			var			context		= new TKDManagerEntities();
			string		titre		= _selectedMember.Gender == 0 ? "Monsieur" : "Madame";

            Graphics	graphics	= e.Graphics;
            Font		font		= new Font("Tahoma", 10, FontStyle.Regular);
			SolidBrush	brush		= new SolidBrush(Color.Black);
			int			posX		= 50;
			int			posY		= 140;
			int			offsetY		= 20;
			Image		logoImage	= new Bitmap("LogoTKDleman.jpg");

			graphics.DrawImage(logoImage, posX, 40);
			
            // Title
			graphics.DrawString("Ecoles de Taekwondo", new Font("Tahoma", 16, FontStyle.Underline | FontStyle.Bold), brush, 270, 50);
			graphics.DrawString("Association de Taekwondo du Léman", new Font("Tahoma", 12, FontStyle.Underline | FontStyle.Bold), brush, 240, 80);

			// Owner address
			graphics.DrawString("Rte de la Gare 32", font, brush, posX, posY);
			posY += offsetY;
			graphics.DrawString("1305 Penthalaz", font, brush, posX, posY);
			posY += offsetY;
			graphics.DrawString("Tel. : 021.861.49.30", font, brush, posX, posY);
			posY += offsetY;
			graphics.DrawString("Nat. : 079.206.76.47", font, brush, posX, posY);
			
			// Member address and date
			posX = 480;
			posY = 200;

			if (string.IsNullOrEmpty(_selectedMember.ResponsiblePerson))
			{ 
				graphics.DrawString(titre, font, brush, posX, posY);
				posY += offsetY;
				graphics.DrawString(_selectedMember.FirstName + " " + _selectedMember.LastName, font, brush, posX, posY);
			}
			else
			{
				posY += offsetY;
				graphics.DrawString(_selectedMember.ResponsiblePerson, font, brush, posX, posY);
			}
			posY += offsetY;
			graphics.DrawString(_selectedMember.Address1, font, brush, posX, posY);
			if (_selectedMember.Address2 != string.Empty)
			{ 
				posY += offsetY;
				graphics.DrawString(_selectedMember.Address2, font, brush, posX, posY);
			}
			posY += offsetY;
			graphics.DrawString(_selectedMember.NPA + " " + _selectedMember.Town, font, brush, posX, posY);
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			graphics.DrawString("Penthalaz, le " + DateTime.Now.Date.ToShortDateString(), font, brush, posX, posY);


			// Content begin
			posX = 50;
			posY = 380;
			
			graphics.DrawString("Membre: " + _selectedMember.MemberID + " " + _selectedMember.FirstName + " " + _selectedMember.LastName, font, brush, posX, posY);
			posY += offsetY;
			font = new Font("Tahoma", 10, FontStyle.Bold);

			posY += offsetY;
			posY += offsetY;
			Fee fee = context.Fee.First(m => m.FeeID == _selectedMember.FeeID);
			graphics.DrawString("Concerne: Paiement de la cotisation mensuelle de: CHF " + fee.FeeAmount + ".-", font, brush, posX, posY);
			posY += offsetY;			
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;

			font = new Font("Tahoma", 10, FontStyle.Regular);
			graphics.DrawString("Cher(ère) membre,", font, brush, posX, posY);
			posY += offsetY;
			graphics.DrawString("Nous vous remercions de votre confiance et espérons que le Taekwondo vous convient!", font, brush, posX, posY);
			posY += offsetY;
			graphics.DrawString("N'hésitez pas à nous contacter si nécessaire.", font, brush, posX, posY);
			posY += offsetY;
			posY += offsetY;
			font = new Font("Tahoma", 10, FontStyle.Bold);
			graphics.DrawString("N'oubliez pas de mentionner sur le paiement le prénom et le nom de l'élève.", font, brush, posX, posY);
			font = new Font("Tahoma", 10, FontStyle.Regular);
			posY += offsetY;
			posY += offsetY;			
			graphics.DrawString("Il ne vous sera pas envoyé d'autres factures. Veuilez trouver ci-joint les bulletins de versement", font, brush, posX, posY); 
			posY += offsetY;
			graphics.DrawString("pour le reste de l'année scolaire", font, brush, posX, posY);
			posY += offsetY;
			posY += offsetY;
			graphics.DrawString(txtMessage.Text, font, brush, posX, posY);
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			posY += offsetY;
			graphics.DrawString("Taekwondosement vôtre, ", font, brush, posX, posY);
			posY += offsetY;
			graphics.DrawString("Le service comptable.", font, brush, 480, posY);

        }
		#endregion



	}
}
