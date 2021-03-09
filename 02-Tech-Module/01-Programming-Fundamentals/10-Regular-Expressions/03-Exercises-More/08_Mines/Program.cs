using System;
using System.Text.RegularExpressions;

namespace _08_Mines
{
	class Program
	{
		static void Main(string[] args)
		{
			string result = string.Empty;

			string input = Console.ReadLine();
			string minePattern = @"(?<mine><.+?>)";
			Regex regex = new Regex(minePattern);
			MatchCollection mc = regex.Matches(input);

			foreach (Match m in mc)
			{
				string matched = m.Groups[0].Value;
				int ch1 = m.Groups["mine"].Value[1];
				int ch2 = m.Groups["mine"].Value[2];
				int blastRadius = Math.Abs(ch1 - ch2);

				string blastPattern = $@"(?<blastRad>.{{0,{blastRadius}}})(?=<){matched}(?<=>)(?<blastRadRight>.{{0,{blastRadius}}})";
				input = Regex.Replace(input, blastPattern, new string('_', Regex.Match(input, blastPattern).Groups[0].Length));
			}
			Console.WriteLine(input);
		}
	}
}
