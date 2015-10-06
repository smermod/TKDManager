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
	public partial class frmMemberEdit : Form
	{
		public int CurrentMemberID { get;set; }
		public int CurrentClubID { get; set; }

		public frmMemberEdit()
		{
			InitializeComponent();

			CurrentMemberID = -1;
		}

		private void frmMemberEdit_Load(object sender, EventArgs e)
		{
			LoadGenders();
			ComboBoxHelper.LoadBelts(cboBelt);
			LoadFees();
			ComboBoxHelper.PopulateYears(cboLicensePaidUntil, true);
			dtpBirthDate.Value = DateTime.Now;
			dtpEntryDate.Value = DateTime.Now;
			
			var context = new TKDManagerEntities();
			txtFirstName.Focus();
            
			if (CurrentMemberID != -1)
            {			
				// Retrieve the user whose ID matches with the ID textbox
				Member member = context.Member.First(m => m.MemberID == CurrentMemberID);

				txtMemberID.Text = member.MemberID.ToString();
				txtFirstName.Text = member.FirstName;
				txtLastName.Text = member.LastName;
				txtResponsiblePerson.Text = member.ResponsiblePerson;
				dtpBirthDate.Value = member.BirthDate ?? DateTime.Now.Date;
				cboGender.SelectedValue = member.Gender;
				txtAddress1.Text = member.Address1;
				txtNPA.Text = member.NPA;
				txtTown.Text = member.Town;
				txtHomePhoneNb.Text = member.HomePhoneNb;
				txtMobilePhoneNb.Text = member.MobilePhoneNb;
				dtpEntryDate.Value = member.EntryDate;
				cboBelt.SelectedValue = member.BeltID;
				cboFee.SelectedValue = member.FeeID;
	            cboLicensePaidUntil.SelectedValue = member.AnnualLicensePaidUntil;
            }

		}

		private void LoadGenders()
		{
			Dictionary<int, string> gendersDictionary = new Dictionary<int, string>();

			gendersDictionary.Add(0, "Masculin");
			gendersDictionary.Add(1, "Feminin");

			cboGender.DataSource = gendersDictionary.ToList();
			cboGender.DisplayMember = "Value";
			cboGender.ValueMember = "Key";
			
		}

		private void LoadFees()
		{
			var context = new TKDManagerEntities();

			var fees = from fee in context.Fee
						orderby fee.FeeID
						select fee;

			cboFee.DataSource = fees.ToList();
			cboFee.DisplayMember = "FeeAmount";
			cboFee.ValueMember = "FeeID";
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveMember();
			
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{
			SaveMember();
			this.Close();
		}

		private void SaveMember()
		{
			var context = new TKDManagerEntities();
			Member member = new Member();

			try
			{
				if (CurrentMemberID == -1)
				{
					member.ClubID = CurrentClubID;
					context.Member.Add(member);
				}
				else
				{
					member = context.Member.First(m => m.MemberID == CurrentMemberID);	            
				}
			
				member.FirstName = txtFirstName.Text;
				member.LastName = txtLastName.Text;
				member.ResponsiblePerson = txtResponsiblePerson.Text;
				member.BirthDate = dtpBirthDate.Value.Date;
				member.Gender = Convert.ToInt32(cboGender.SelectedValue.ToString());
				member.Address1 = txtAddress1.Text;
				member.NPA = txtNPA.Text;
				member.Town = txtTown.Text;
				member.HomePhoneNb = txtHomePhoneNb.Text;
				member.MobilePhoneNb = txtMobilePhoneNb.Text;
				member.EntryDate = dtpEntryDate.Value.Date;
				member.BeltID = Convert.ToInt32(cboBelt.SelectedValue.ToString());
				member.FeeID = Convert.ToInt32(cboFee.SelectedValue.ToString());
				member.AnnualLicensePaidUntil = Convert.ToInt32(cboLicensePaidUntil.SelectedValue.ToString());
				context.SaveChanges();

				((frmMain)(Owner)).RefreshGrid(CurrentMemberID);

				MessageBox.Show(this, "Données sauvées avec succès.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			CurrentMemberID = -1;
			txtFirstName.Focus();

			txtMemberID.Text = string.Empty;
			txtFirstName.Text = string.Empty;
			txtLastName.Text = string.Empty;
			txtResponsiblePerson.Text = string.Empty;
			txtAddress1.Text = string.Empty;
			txtNPA.Text = string.Empty;
			txtTown.Text = string.Empty;
			txtHomePhoneNb.Text = string.Empty;
			txtMobilePhoneNb.Text = string.Empty;

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
