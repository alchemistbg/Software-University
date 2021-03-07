using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_Star_Enigma
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> attackedPlanets = new List<string>();
			List<string> destroyedPlanets = new List<string>();

			int messagesNumber = int.Parse(Console.ReadLine());

			for (int i = 0; i < messagesNumber; i++)
			{
				string cryptedMessage = Console.ReadLine();
				int offset = 0;

				for (int j = 0; j < cryptedMessage.Length; j++)
				{
					string s = "" + cryptedMessage[j];
					if (s.ToLower().Contains("s") || s.ToLower().Contains("t") || s.ToLower().Contains("a") || s.ToLower().Contains("r"))
					{
						offset++;
					}
				}

				StringBuilder sb = new StringBuilder();
				for (int j = 0; j < cryptedMessage.Length; j++)
				{
					int s = cryptedMessage[j] - offset;
					char ch = (char)s;
					sb.Append(ch);
				}

				string pattern = @"[^@:\->!]*@(?<name>[A-Za-z]+)[^@:\->!]*:(\d+)[^@:\->!]*!(?<type>A|D)![^@:\->!]*->(\d+)[^@:\->!]*";
				string planetName = string.Empty;
				string attackType = string.Empty;
				MatchCollection match = Regex.Matches(sb.ToString(), pattern);
				foreach (Match m in match)
				{
					planetName = m.Groups["name"].ToString();
					attackType = m.Groups["type"].ToString();
				}

				if (attackType == "A")
				{
					attackedPlanets.Add(planetName);
				}

				if (attackType == "D")
				{
					destroyedPlanets.Add(planetName);
				}
			}

			Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
			if (attackedPlanets.Count > 0)
			{
				foreach (string planet in attackedPlanets.OrderBy(x => x))
				{
					Console.WriteLine($"-> {planet}");
				}
			}
			Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
			if (destroyedPlanets.Count > 0)
			{
				foreach (string planet in destroyedPlanets.OrderBy(x => x))
				{
					Console.WriteLine($"-> {planet}");
				}
			}
		}
	}
}
