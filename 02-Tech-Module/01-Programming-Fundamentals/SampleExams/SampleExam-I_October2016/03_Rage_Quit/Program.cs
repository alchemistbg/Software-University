using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Rage_Quit
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"(?<chars>[^\d]+)(?<digit>\d+)";
			StringBuilder sb = new StringBuilder();
			MatchCollection mc = Regex.Matches(input, pattern);
			foreach (Match m in mc)
			{
				string s = m.Groups["chars"].Value;
				s = s.ToUpper();
				int repeats = int.Parse(m.Groups["digit"].Value);
				for (int i = 0; i < repeats; i++)
				{
					sb.Append(s);
				}
			}

			int uniqueSymbols = sb.ToString().ToCharArray().Distinct().Count();
			Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
			Console.WriteLine(sb);
		}
	}
}
