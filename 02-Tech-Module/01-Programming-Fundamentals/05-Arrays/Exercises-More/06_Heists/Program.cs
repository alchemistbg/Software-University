using System;
using System.Linq;

namespace _06_Heists
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int jewelPrice = prices[0];
			int goldPrice = prices[1];

			int totalEarnings = 0;
			int totalExpenses = 0;

			string input = Console.ReadLine();
			while (input != "Jail Time")
			{
				string[] heistInfo = input.Split(' ').ToArray();
				string loot = heistInfo[0];
				int expenses = int.Parse(heistInfo[1]);

				for (int i = 0; i < loot.Length; i++)
				{
					if (loot[i] == '%')
					{
						totalEarnings += jewelPrice;
					}
					else if (loot[i] == '$')
					{
						totalEarnings += goldPrice;
					}

				}

				totalExpenses += expenses;
				input = Console.ReadLine();
			}

			int diff = Math.Abs(totalEarnings - totalExpenses);

			if (totalEarnings >= totalExpenses)
			{
				Console.WriteLine($"Heists will continue. Total earnings: {diff}.");
			}
			else
			{
				Console.WriteLine($"Have to find another job. Lost: {diff}.");
			}
		}
	}
}
