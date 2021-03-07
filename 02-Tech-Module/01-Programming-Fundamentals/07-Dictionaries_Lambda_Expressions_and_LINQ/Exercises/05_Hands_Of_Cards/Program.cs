using System;
using System.Collections.Generic;

namespace _05_Hands_Of_Cards
{
	class Program
	{
		static Dictionary<String, int> cardsPoints = new Dictionary<string, int>(){
			{"2", 2},
			{"3", 3},
			{"4", 4},
			{"5", 5},
			{"6", 6},
			{"7", 7},
			{"8", 8},
			{"9", 9},
			{"10", 10},
			{"J", 11},
			{"Q", 12},
			{"K", 13},
			{"A", 14}
		};
		static Dictionary<String, int> multipliers = new Dictionary<string, int>(){
			{"C", 1},
			{"D", 2},
			{"H", 3},
			{"S", 4},
		};

		static Dictionary<String, List<String>> playersStat = new Dictionary<string, List<String>>();

		public static void Main(String[] args)
		{
			String input = Console.ReadLine();
			while (!input.Equals("JOKER"))
			{
				inputParser(input);
				input = Console.ReadLine();
			}
			printPoints();
		}

		public static void inputParser(String input)
		{
			String playerName = input.Split(": ")[0];
			List<String> playerCards = new List<string>(input.Split(": ")[1].Split(", "));
			if (!playersStat.ContainsKey(playerName))
			{
				playersStat.Add(playerName, playerCards);
			}
			else
			{
				playersStat[playerName].AddRange(playerCards);
			}
			HashSet<String> hSet = new HashSet<string>(playersStat[playerName]);
			List<String> tempList = new List<string>(hSet);
			playersStat[playerName] = tempList;
		}

		public static void printPoints()
		{
			foreach (var item in playersStat)
			{
				int playerPoints = pointsCalculator(item.Value.ToArray());
				Console.WriteLine($"{item.Key}: {playerPoints}");
			}
		}

		public static int pointsCalculator(String[] drawnCards)
		{
			int points = 0;
			foreach (String card in drawnCards)
			{
				String cardType = "";
				String cardSuite = "";
				if (card.Length == 2)
				{
					cardType = card.Substring(0, 1);
					cardSuite = card.Substring(1);
				}
				else
				{
					cardType = card.Substring(0, 2);
					cardSuite = card.Substring(2);
				}

				points = points + cardsPoints[cardType] * multipliers[cardSuite];
			}
			return points;
		}
	}
}
