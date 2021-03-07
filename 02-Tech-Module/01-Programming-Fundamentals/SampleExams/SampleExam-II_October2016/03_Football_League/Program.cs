using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_Football_League
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Team> teams = new Dictionary<string, Team>();
			string keyString = Console.ReadLine();

			string input = Console.ReadLine();
			while (input != "final")
			{
				string pattern = @"(?<key>" + Regex.Escape(keyString) + @")(?<teamName>.*?)(\k<key>)";
				MatchCollection mc = Regex.Matches(input, pattern);
				string team0 = string.Join("", mc[0].Groups["teamName"].ToString().ToCharArray().Reverse()).ToUpper();
				string team1 = string.Join("", mc[1].Groups["teamName"].ToString().ToCharArray().Reverse()).ToUpper();

				long[] scores = input.Substring(input.LastIndexOf(' ') + 1).Split(':').Select(long.Parse).ToArray();
				long score0 = scores[0];
				long score1 = scores[1];

				long points0 = 0L;
				long points1 = 0L;
				if (score0 > score1)
				{
					points0 = 3;
				}
				else if (score1 > score0)
				{
					points1 = 3;
				}
				else
				{
					points0 = 1;
					points1 = 1;
				}

				Team t0 = new Team();
				if (!teams.ContainsKey(team0))
				{
					teams[team0] = t0;
				}
				teams[team0].Points += points0;
				teams[team0].ScoredGoals += score0;

				Team t1 = new Team();
				if (!teams.ContainsKey(team1))
				{
					teams[team1] = t1;
				}
				teams[team1].Points += points1;
				teams[team1].ScoredGoals += score1;

				input = Console.ReadLine();
			}

			Console.WriteLine("League standings:");
			int counter = 1;
			foreach (var t in teams.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key))
			{
				Console.WriteLine($"{counter}. {t.Key} {t.Value.Points}");
				counter++;
			}

			Console.WriteLine("Top 3 scored goals:");
			foreach (var t in teams.OrderByDescending(x => x.Value.ScoredGoals).ThenBy(x => x.Key).Take(3))
			{
				Console.WriteLine($"- {t.Key} -> {t.Value.ScoredGoals}");
			}
		}
	}

	class Team
	{
		public long Points { get; set; }
		public long ScoredGoals { get; set; }

		public Team()
		{
			Points = 0L;
			ScoredGoals = 0L;
		}
	}
}
