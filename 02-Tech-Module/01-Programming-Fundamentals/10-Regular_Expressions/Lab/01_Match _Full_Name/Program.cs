using System;
using System.Text.RegularExpressions;

namespace _01_Match__Full_Name
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

			Regex regex = new Regex(pattern);
			MatchCollection mc = regex.Matches(input);

			foreach (Match match in mc)
			{
				Console.Write(match.Value + " ");

			}
			Console.WriteLine();
		}

		//public static void Main()
		//{
		//	string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
		//	string input = Console.ReadLine();

		//	RegexOptions options = RegexOptions.Multiline;

		//	MatchCollection matchedNames = Regex.Matches(input, pattern);

		//	foreach (Match m in matchedNames)
		//	{
		//		Console.Write($"{m} ");
		//	}
		//}
	}
}
