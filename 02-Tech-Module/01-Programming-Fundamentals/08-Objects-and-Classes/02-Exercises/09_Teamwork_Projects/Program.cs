using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Teamwork_Projects
{
	class Program
	{
		static int num = 0;
		static Dictionary<string, Team> teams = new Dictionary<string, Team>();
		static void Main(string[] args)
		{
			num = int.Parse(Console.ReadLine());
			string input = string.Empty;

			while (input != "end of assignment")
			{
				input = Console.ReadLine();

				if (input.Contains("->"))
				{
					parseMember(input);
				}
				else if (input.Contains("-"))
				{
					parseLeader(input);
				}
			}

			var nonEmptyTeams = teams.Where(x => x.Value.Members.Count > 0).ToDictionary(x => x.Key, x => x.Value);
			foreach (var team in nonEmptyTeams.OrderByDescending(x => x.Value.Members.Count()).ThenBy(y => y.Key))
			{
				Console.WriteLine(team.Key);
				Console.WriteLine($"- {team.Value.Creator}");
				foreach (var member in team.Value.Members.OrderBy(x => x))
				{
					Console.WriteLine($"-- {member}");
				}
			}

			Console.WriteLine("Teams to disband:");
			var emptyTeams = teams.Where(x => x.Value.Members.Count == 0).ToDictionary(x => x.Key, x => x.Value);
			foreach (var team in emptyTeams.OrderBy(x => x.Key))
			{
				Console.WriteLine(team.Key);
			}
		}

		private static void parseLeader(string input)
		{
			string[] inputLeader = input.Split('-').ToArray();
			string creatorName = inputLeader[0];
			string teamName = inputLeader[1];

			if (teams.ContainsKey(teamName))
			{
				Console.WriteLine($"Team {teamName} was already created!");
			}
			else
			{
				if (teams.Values.Select(x => x.Creator).Contains(creatorName))
				{
					Console.WriteLine($"{creatorName} cannot create another team!");
				}
				else if (teams.Values.SelectMany(x => x.Members).Contains(creatorName))
				{
					Console.WriteLine($"Member {creatorName} cannot join team {teamName}!");
				}
				else
				{
					Team team = new Team();
					team.Name = teamName;
					team.Creator = creatorName;
					teams.Add(teamName, team);
					Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
				}
			}
		}

		private static void parseMember(string input)
		{
			string[] inputMember = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			string memberName = inputMember[0];
			string teamName = inputMember[1];

			if (teams.ContainsKey(teamName))
			{
				if (teams.Values.Select(x => x.Creator).Contains(memberName))
				{
					Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
				}
				else if (teams.Values.SelectMany(x => x.Members).Contains(memberName))
				{
					Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
				}
				else
				{
					teams[teamName].Members.Add(memberName);
				}
			}
			else
			{
				Console.WriteLine($"Team {teamName} does not exist!");
			}
		}
	}

	class Team
	{
		public string Name { get; set; }
		public string Creator { get; set; }
		public List<string> Members { get; set; }

		public Team()
		{
			this.Name = string.Empty;
			this.Creator = string.Empty;
			this.Members = new List<string>();
		}
	}
}
