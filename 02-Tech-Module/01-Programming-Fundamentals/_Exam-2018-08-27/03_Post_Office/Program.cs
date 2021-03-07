using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_Post_Office
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split("|");
			string capitalLettersPattern = @"(?<start>[#$%&])(?<middle>[A-Z]+)(?<end>\k<start>)";
			string capitalLetters = Regex.Match(input[0], capitalLettersPattern).Groups["middle"].ToString();

			string capitalLettersCharsPattern = @"\d{2}:\d{2}";
			MatchCollection mc = Regex.Matches(input[1], capitalLettersCharsPattern);
			List<string> validCapitalLetters = new List<string>();
			foreach (Match m in mc)
			{
				int startChar = int.Parse(m.Value.Split(":")[0]);
				int length = int.Parse(m.Value.Split(":")[1]);
				if (startChar >= 65 && startChar <= 90 && capitalLetters.Contains((char)startChar) && !validCapitalLetters.Contains(m.Value))
				{
					validCapitalLetters.Add(m.Value);
				}
			}

			List<string> validWords = new List<string>();
			string[] words = input[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < validCapitalLetters.Count; i++)
			{
				char capitalLetter = (char)int.Parse(validCapitalLetters[i].Split(":")[0]);
				int stringLength = int.Parse(validCapitalLetters[i].Split(":")[1]) + 1;
				for (int j = 0; j < words.Length; j++)
				{
					if (words[j].StartsWith(capitalLetter) && words[j].Length == stringLength)
					{
						if (!validWords.Contains(words[j]))
						{
							validWords.Add(words[j]);
						}
					}
				}
			}

			//List<string> printed = new List<string>();
			for (int i = 0; i < capitalLetters.Length; i++)
			{
				foreach (string s in validWords)
				{
					if (s.StartsWith(capitalLetters[i]))// && !printed.Contains(s))
					{
						//printed.Add(s);
						Console.WriteLine(s);
					}
				}
			}
		}
	}
}
