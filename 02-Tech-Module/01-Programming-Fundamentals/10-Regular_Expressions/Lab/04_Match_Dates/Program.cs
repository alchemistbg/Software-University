using System;
using System.Text.RegularExpressions;

namespace _04_Match_Dates
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"(?<day>\d{2})(?<sep>[\/\-\.])(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})";

			Regex regex = new Regex(pattern);
			MatchCollection mc = regex.Matches(input);

			foreach (Match m in mc)
			{
				Console.WriteLine($"Day: {m.Groups[1]}, Month: {m.Groups[3]}, Year: {m.Groups[4]}");
			}
		}

		//static void Main(string[] args)
		//{
		//	string pattern = @"\b(?<day>\d{2})(?<sep>\.|\/|-)(?<month>[A-Z][a-z]+)(\k<sep>)(?<year>[\d]{4})\b";
		//	string input = Console.ReadLine();

		//	MatchCollection matchedDates = Regex.Matches(input, pattern);

		//	foreach (Match date in matchedDates)
		//	{
		//		string d = date.Groups["day"].Value;
		//		string m = date.Groups["month"].Value;
		//		string y = date.Groups["year"].Value;

		//		Console.WriteLine($"Day: {d}, Month: {m}, Year: {y}");
		//	}
		//}
	}
}
