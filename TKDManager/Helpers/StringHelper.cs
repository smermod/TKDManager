using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKDManager.Helpers
{
	class StringHelper
	{
		public static int GetClubNumberFromConcat(string club)
		{
			int retval = Convert.ToInt32(club.Substring(0, club.IndexOf("-") - 1));
			
			return retval;
		}
	}
}
