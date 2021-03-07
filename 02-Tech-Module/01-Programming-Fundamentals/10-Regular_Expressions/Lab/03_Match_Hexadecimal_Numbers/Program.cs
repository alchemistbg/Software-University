using System;
using System.Text.RegularExpressions;

namespace _03_Match_Hexadecimal_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"\b(0x)?[0-9A-F]+\b";

			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(input);

			foreach (Match m in matches)
			{
				Console.Write(m.Value + " ");
			}
			Console.WriteLine();
		}

		//static void Main(string[] args)
		//{
		//	string pattern = @"\b(0x)?[0-9A-F]+\b";
		//	string input = Console.ReadLine();

		//	MatchCollection matchedNames = Regex.Matches(input, pattern);
		//	Console.WriteLine(string.Join(" ", matchedNames));
		//}
	}
}
