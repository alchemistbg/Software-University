using System;
using System.Text.RegularExpressions;

namespace _03_Regexmon
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string didiPattern = @"[^A-Za-z\-]+";
			string bojoPattern = @"[A-Za-z]+-[A-Za-z]+";

			while (true)
			{
				Regex didiRegex = new Regex(didiPattern);
				Match didiMatch = didiRegex.Match(input);
				if (didiMatch.Success)
				{
					Console.WriteLine(didiMatch);
					input = input.Substring(didiMatch.Index + didiMatch.Length);
				}
				else
				{
					break;
				}

				Regex bojoRegex = new Regex(bojoPattern);
				Match bojoMatch = bojoRegex.Match(input);
				if (bojoMatch.Success)
				{
					Console.WriteLine(bojoMatch);
					input = input.Substring(bojoMatch.Index + bojoMatch.Length);
				}
				else
				{
					break;
				}
			}
		}
	}
}
