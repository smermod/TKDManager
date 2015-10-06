using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKDManager.Models;

namespace TKDManager.Helpers
{
	class DataGridViewHelper
	{
		public static void SetMainColumnName(DataGridView grd)
		{
			Dictionary<int, string> columnNameDictionary = new Dictionary<int, string>();
			columnNameDictionary.Add(0, "No Membre");
			columnNameDictionary.Add(1, "Prénom");
			columnNameDictionary.Add(2, "Nom de famille");
			columnNameDictionary.Add(3, "Date de n.");
			columnNameDictionary.Add(4, "Genre");
			columnNameDictionary.Add(5, "Adresse");
			columnNameDictionary.Add(6, "Adresse 2");
			columnNameDictionary.Add(7, "NPA");
			columnNameDictionary.Add(8, "Localité");
			columnNameDictionary.Add(9, "Email");
			columnNameDictionary.Add(10, "Tél. fixe");
			columnNameDictionary.Add(11, "Tél. prof.");
			columnNameDictionary.Add(12, "Tél. mobile");
			columnNameDictionary.Add(13, "Entrée");
			columnNameDictionary.Add(14, "Sortie");
			columnNameDictionary.Add(15, "Grade");
			columnNameDictionary.Add(16, "ClubID");
			columnNameDictionary.Add(17, "FeeID");
			columnNameDictionary.Add(18, "Pers. responsable");
			columnNameDictionary.Add(19, "License payée pour");

			foreach (var column in columnNameDictionary)
			{
				grd.Columns[column.Key].HeaderText = column.Value;
			}			
		}

		public static void SetSimpleMemberColumnName(DataGridView grd)
		{
			Dictionary<int, string> columnNameDictionary = new Dictionary<int, string>();
			columnNameDictionary.Add(0, "No");
			columnNameDictionary.Add(1, "Prénom");
			columnNameDictionary.Add(2, "Nom de famille");

			foreach (var column in columnNameDictionary)
			{
				grd.Columns[column.Key].HeaderText = column.Value;
			}			
		}

		public static void SetPaymentsColumnName(DataGridView grd)
		{
			Dictionary<int, string> columnNameDictionary = new Dictionary<int, string>();
			columnNameDictionary.Add(0, "No");
			columnNameDictionary.Add(1, "Prénom");
			columnNameDictionary.Add(2, "Nom de famille");
			columnNameDictionary.Add(3, "Montant");

			foreach (var column in columnNameDictionary)
			{
				grd.Columns[column.Key].HeaderText = column.Value;
			}			
		}

		public static void SetColumnWidthAndVisibility(DataGridView grd)
		{
			
		}

		public static string SetGenderLookup(string value)
		{
			string retval;

			switch (value)
			{
				case "0":
					retval = "Masculin";
					break;
				case "1":
					retval = "Feminin";
					break;
				default:
					retval = "Masculin";
					break;
			}

			return retval;
		}


		public static string SetBeltLookup(string value)
		{
			string retval;

			var context = new TKDManagerEntities();

			Belt belt = context.Belt.First(b => b.BeltID.ToString() == value);

			retval = belt.BeltDescription;

			return retval;
		}
	}
}
