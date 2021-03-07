using System;
using System.Text.RegularExpressions;

namespace _01_Extract_Emails
{
	class Program
	{
		static void Main(string[] args)
		{
			string patterrn = @"(^|(?<=\s))([A-Za-z]+|\d+)(\.|-|_)?(\w+|\d+)@(\w+)(-\w+)?(\.\w+)+";
			string input = Console.ReadLine();

			MatchCollection matches = Regex.Matches(input, patterrn);
			foreach (var item in matches)
			{
				Console.WriteLine(item);
			}
		}
	}
}
