using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKDManager.Models;

namespace TKDManager.Helpers
{
	class ComboBoxHelper
	{
		public static void PopulateMonths(ComboBox cbo)
		{
			Dictionary<int, string> months = new Dictionary<int, string>();

			months.Add(1, "Janvier");
			months.Add(2, "Février");
			months.Add(3, "Mars");
			months.Add(4, "Avril");
			months.Add(5, "Mai");
			months.Add(6, "Juin");
			months.Add(7, "Juillet");
			months.Add(8, "Août");
			months.Add(9, "Septembre");
			months.Add(10, "Octobre");
			months.Add(11, "Novembre");
			months.Add(12, "Décembre");

			cbo.DataSource = months.ToList();
			cbo.DisplayMember = "Value";
			cbo.ValueMember = "Key";
		}

		public static void PopulateYears(ComboBox cbo, bool addEmpty = false)
		{
			Dictionary<int, string> years = new Dictionary<int, string>();
			
			if (addEmpty) years.Add(0, "");

			for (int idx = 2014; idx < DateTime.Now.Year + 3; idx++)
			{
				years.Add(idx, idx.ToString());
			}

			cbo.DataSource = years.ToList();
			cbo.DisplayMember = "Value";
			cbo.ValueMember = "Key";
		}

		public static void SelectCurrentPeriod(ComboBox cboMonth, ComboBox cboYear)
		{
			cboMonth.SelectedValue = DateTime.Now.AddMonths(1).Month;
			cboYear.SelectedValue = DateTime.Now.AddYears(DateTime.Now.AddMonths(1).Month == 12 ? 1 : 0).Year;			
		}

		public static void LoadBelts(ComboBox cbo, bool withEmptyEntry = false, string valueMember = "BeltID")
		{
			var context = new TKDManagerEntities();

			var belts = from belt in context.Belt
						orderby belt.BeltID
						select belt;

			var beltsList = belts.ToList();
			if (withEmptyEntry) beltsList.Add(new Belt() {BeltID = -1, BeltDescription = "", BeltKeup = ""});

			cbo.DataSource = beltsList;
			cbo.DisplayMember = "BeltDescription";
			cbo.ValueMember = valueMember;

		}
	}
}
