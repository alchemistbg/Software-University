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
			Dictionary<string, Team> standing = new Dictionary<string, Team>();

			string key = Console.ReadLine();

			Regex regex = new Regex(Regex.Escape(key) + "[A-Za-z]*" + Regex.Escape(key));

			string input = Console.ReadLine();
			while (input != "final")
			{
				string[] inputArray = input.Split(' ');

				string firstTeamName = regex.Match(inputArray[0]).Groups[0].Value;
				firstTeamName = string.Join("", firstTeamName.Replace(key, "").ToCharArray().Reverse()).ToUpper();

				string secondTeamName = regex.Match(inputArray[1]).Groups[0].Value;
				secondTeamName = string.Join("", secondTeamName.Replace(key, "").ToCharArray().Reverse()).ToUpper();

				int[] score = inputArray[2].Split(':').Select(int.Parse).ToArray();
				int firstTeamGoals = score[0];
				int secondTeamGoals = score[1];

				int firstTeamPoints = 0;
				int secondTeamPoints = 0;
				if (firstTeamGoals > secondTeamGoals)
				{
					firstTeamPoints = 3;
				}
				else if (firstTeamGoals < secondTeamGoals)
				{
					secondTeamPoints = 3;
				}
				else
				{
					firstTeamPoints = 1;
					secondTeamPoints = 1;
				}


				if (!standing.ContainsKey(firstTeamName))
				{
					Team ft = new Team(firstTeamName);
					standing.Add(firstTeamName, ft);
				}

				if (!standing.ContainsKey(secondTeamName))
				{
					Team st = new Team(secondTeamName);
					standing.Add(secondTeamName, st);
				}

				standing[firstTeamName].ScoredGoald += firstTeamGoals;
				standing[firstTeamName].Points += firstTeamPoints;

				standing[secondTeamName].ScoredGoald += secondTeamGoals;
				standing[secondTeamName].Points += secondTeamPoints;

				input = Console.ReadLine();
			}

			Console.WriteLine("League standings:");
			int standingCounter = 1;
			foreach (var team in standing.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Value.Name))
			{
				Console.WriteLine($"{standingCounter}. {team.Value.Name} {team.Value.Points}");
				standingCounter++;
			}

			Console.WriteLine("Top 3 scored goals:");
			foreach (var team in standing.OrderByDescending(x => x.Value.ScoredGoald).ThenBy(x => x.Value.Name).Take(3))
			{
				Console.WriteLine($"- {team.Value.Name} -> {team.Value.ScoredGoald}");
			}
		}
	}

	class Team
	{
		public string Name { get; set; }
		public int Points { get; set; }
		public int ScoredGoald { get; set; }

		public Team(String name)
		{
			this.Name = name;
			this.Points = 0;
			this.ScoredGoald = 0;
		}
	}
}
