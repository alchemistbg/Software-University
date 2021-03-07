using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_MOBA_Challenger
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Player> tier = new Dictionary<string, Player>();

			string input = Console.ReadLine();
			while (input != "Season end")
			{
				if (input.Contains(" -> "))
				{
					string[] inputArr = input.Split(" -> ");
					string name = inputArr[0];
					string position = inputArr[1];
					int skill = int.Parse(inputArr[2]);

					if (!tier.ContainsKey(name))
					{
						Player player = new Player();
						tier.Add(name, player);
					}
					tier[name].Name = name;

					if (!tier[name].Stat.ContainsKey(position))
					{
						tier[name].Stat[position] = skill;
					}
					else
					{
						tier[name].Stat[position] = Math.Max(tier[name].Stat[position], skill);
					}
				}

				if (input.Contains(" vs "))
				{
					string[] inputArr = input.Split(" vs ");
					string player1 = inputArr[0];
					string player2 = inputArr[1];

					if (tier.ContainsKey(player1) && tier.ContainsKey(player2))
					{
						var commonKeys = tier[player1].Stat.Keys.Intersect(tier[player2].Stat.Keys);
						if (commonKeys.Count() > 0)
						{
							if (tier[player1].Stat.Sum(x => x.Value) > tier[player2].Stat.Sum(x => x.Value))
							{
								tier.Remove(player2);
							}
							else if (tier[player1].Stat.Sum(x => x.Value) < tier[player2].Stat.Sum(x => x.Value))
							{
								tier.Remove(player1);
							}
						}
					}
				}

				input = Console.ReadLine();
			}

			foreach (var player in tier.OrderByDescending(x => x.Value.Stat.Sum(y => y.Value)).ThenBy(x => x.Value.Name))
			{
				Console.WriteLine($"{player.Value.Name}: {player.Value.Stat.Sum(y => y.Value)} skill");
				foreach (var statRecord in player.Value.Stat.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
				{
					Console.WriteLine($"- {statRecord.Key} <::> {statRecord.Value}");
				}
			}
		}
	}

	class Player
	{
		public string Name { get; set; }
		public Dictionary<string, int> Stat { get; set; }

		public Player()
		{
			this.Stat = new Dictionary<string, int>();
		}
	}
}
