using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CardGame
{
	public static class Helper
	{

		public static string ConnString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}


	}
}
