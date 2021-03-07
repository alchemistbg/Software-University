using System;
using System.Text.RegularExpressions;

namespace _05_Only_Letters
{
	class Program
	{
		public static void Main()
		{
			string input = Console.ReadLine();

			string pattern = @"(?<number>\d+)(?<letter>[A-Za-z])";
			string substitution = @"${letter}${letter}";
			RegexOptions options = RegexOptions.Multiline;

			Regex regex = new Regex(pattern, options);
			string result = regex.Replace(input, substitution);

			Console.WriteLine(result);
		}
	}
}
