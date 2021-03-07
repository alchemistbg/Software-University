using System;
using System.Text.RegularExpressions;

namespace _07_Hideout
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] searched = Console.ReadLine().Split(" ");

			bool repeat = true;

			while (repeat)
			{
				string symbol = Regex.Escape(searched[0]);
				int minRepeats = int.Parse(searched[1]);
				string pattern = $"([{symbol}]{{{minRepeats},}})";

				string match = Regex.Match(input, pattern).ToString();
				if (match.Length > 0)
				{
					int searchedLength = match.Length;
					int searchedIndex = input.IndexOf(match);
					Console.WriteLine($"Hideout found at index {searchedIndex} and it is with size {searchedLength}!");
					repeat = false;
				}
				else
				{
					searched = Console.ReadLine().Split(" ");
				}
			}

		}
	}
}
