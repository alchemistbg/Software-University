using System;
using System.Text.RegularExpressions;

namespace _05_Match_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

			Regex regex = new Regex(pattern);
			MatchCollection mc = regex.Matches(input);

			foreach (Match m in mc)
			{
				Console.Write(m + " ");
			}
			Console.WriteLine();
		}

		//static void Main(string[] args)
		//{
		//	string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
		//	string input = Console.ReadLine();

		//	MatchCollection matchedNames = Regex.Matches(input, pattern);

		//	Console.WriteLine(string.Join(" ", matchedNames));
		//}
	}
}
