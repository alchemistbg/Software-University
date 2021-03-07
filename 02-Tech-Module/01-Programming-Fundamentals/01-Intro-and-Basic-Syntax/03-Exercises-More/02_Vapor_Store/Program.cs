using System;
using System.Collections.Generic;

namespace _02_Vapor_Store
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> catalog = new Dictionary<string, double>()
			{
				{ "OutFall 4", 39.99},
				{ "CS: OG", 15.99},
				{ "Zplinter Zell", 19.99},
				{ "Honored 2", 59.99},
				{ "RoverWatch", 29.99},
				{ "RoverWatch Origins Edition", 39.99},
			};

			double initialBalance = double.Parse(Console.ReadLine());
			double currentBalance = initialBalance;
			string query = Console.ReadLine();

			while (query != "Game Time")
			{
				if (catalog.ContainsKey(query))
				{
					if (currentBalance >= catalog[query])
					{
						currentBalance -= catalog[query];
						Console.WriteLine($"Bought {query}");
						if (currentBalance == 0.0)
						{
							Console.WriteLine("Out of money!");
							break;
						}
					}
					else
					{
						Console.WriteLine("Too Expensive");
					}
				}
				else
				{
					Console.WriteLine("Not Found");
				}

				query = Console.ReadLine();
			}

			Console.WriteLine($"Total spent: ${(initialBalance - currentBalance):f2}. Remaining: ${currentBalance:f2}");
		}
	}
}
