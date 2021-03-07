using System;
using System.Linq;

namespace _04_Trifon_s_Quest
{
	class Program
	{
		static long health = 0;
		static int totalTurns = 0;
		static void Main(string[] args)
		{
			health = int.Parse(Console.ReadLine());
			int[] mapDimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int rows = mapDimension[0];
			int cols = mapDimension[1];

			string[,] map = new string[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				string singleRow = Console.ReadLine();
				for (int j = 0; j < cols; j++)
				{
					map[i, j] = "" + singleRow[j];
				}
			}

			for (int i = 0; i < cols; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 0; j < rows; j++)
					{
						string obstacle = map[j, i];
						makeTurn(obstacle);
						if (health <= 0)
						{
							Console.WriteLine($"Died at: [{j}, {i}]");
							return;
						}
					}
				}
				else
				{
					for (int j = rows - 1; j >= 0; j--)
					{
						string obstacle = map[j, i];
						makeTurn(obstacle);
						if (health <= 0)
						{
							Console.WriteLine($"Died at: [{j}, {i}]");
							return;
						}
					}
				}
			}
			Console.WriteLine("Quest completed!");
			Console.WriteLine($"Health: {health}");
			Console.WriteLine($"Turns: {totalTurns}");
		}

		static void makeTurn(string obstacle)
		{
			int turnHealth = 0;
			switch (obstacle)
			{
				case "F":
					turnHealth = totalTurns / 2;
					health -= turnHealth;
					totalTurns++;
					break;
				case "H":
					turnHealth = totalTurns / 3;
					health += turnHealth;
					totalTurns++;
					break;
				case "T":
					totalTurns += 3;
					break;
				default:
					totalTurns++;
					break;
			}
		}
	}
}
