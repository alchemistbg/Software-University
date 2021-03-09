using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_Match_Phone_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"\+359(?<sep>[ |-])2\k<sep>\d{3}\k<sep>\d{4}\b";

			Regex regex = new Regex(pattern);
			MatchCollection mc = regex.Matches(input);

			List<string> valid = new List<string>();
			foreach (Match match in mc)
			{
				valid.Add(match.Value);
			}
			Console.WriteLine(string.Join(", ", valid));
		}

		//static void Main(string[] args)
		//{
		//	string pattern = @"\+359(?<separator> |-)2(\k<separator>)\d{3}(\k<separator>)\d{4}\b";
		//	string input = Console.ReadLine();

		//	MatchCollection matchedNames = Regex.Matches(input, pattern);

		//	Console.WriteLine(string.Join(", ", matchedNames));
		//}
	}
}
