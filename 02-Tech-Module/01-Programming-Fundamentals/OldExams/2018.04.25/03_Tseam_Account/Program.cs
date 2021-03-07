using System;

namespace _03_Tseam_Account
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> games = Console.ReadLine().Split(' ').ToList();

			string commandString = Console.ReadLine();
			while (commandString != "Play!")
			{
				string[] commArr = commandString.Split(" ");
				string command = commArr[0];
				string game = commArr[1];

				switch (command)
				{
					case "Install":
						if (!games.Contains(game))
						{
							games.Add(game);
						}
						break;
					case "Uninstall":
						if (games.Contains(game))
						{
							games.Remove(game);
						}
						break;
					case "Update":
						if (games.Contains(game))
						{
							games.Remove(game);
							games.Add(game);
						}
						break;
					case "Expansion":
						string[] gameExp = game.Split("-");
						string gameToExp = gameExp[0];
						string exp = gameExp[1];

						if (games.Contains(gameToExp))
						{
							games.Insert(games.IndexOf(gameToExp) + 1, $"{gameToExp}:{exp}");
						}
						break;
					default:
						break;
				}

				commandString = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", games));
		}
	}
}
