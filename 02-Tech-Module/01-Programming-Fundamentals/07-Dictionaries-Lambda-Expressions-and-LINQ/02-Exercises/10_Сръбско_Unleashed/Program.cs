using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Сръбско_Unleashed
{
	class Program
	{
		static string singer = "";
		static string venue = "";
		static int ticketsPrice = 0;
		static int ticketsCount = 0;

		static Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			parseInput(input);

			while (input != "End")
			{
				input = Console.ReadLine();
				parseInput(input);
			}

			printer();
		}

		private static void printer()
		{
			foreach (var item in data)
			{
				Console.WriteLine(item.Key);

				foreach (var item1 in item.Value.OrderByDescending(x => x.Value))
				{
					Console.WriteLine($"#  {item1.Key} -> {item1.Value}");
				}
			}
		}

		private static void parseInput(string input)
		{
			if (input != "End")
			{
				string[] firstSplit = input.Split("@");

				if (firstSplit[0].EndsWith(" "))
				{
					singer = firstSplit[0];


					string[] secondSplit = firstSplit[1].Split(" ");
					try
					{
						ticketsCount = int.Parse(secondSplit[secondSplit.Length - 1]);

						try
						{
							ticketsPrice = int.Parse(secondSplit[secondSplit.Length - 2]);

							venue = string.Join(' ', secondSplit, 0, secondSplit.Length - 2);

							entryData(venue.Trim(), singer.Trim(), ticketsPrice, ticketsCount);
						}
						catch (Exception)
						{

						}
					}
					catch (Exception)
					{

					}
				}
			}
		}

		static void entryData(string v, string s, int tp, int tc)
		{
			int totalMoney = tp * tc;
			if (!data.ContainsKey(v))
			{
				data.Add(v, new Dictionary<string, int>()
				{
					{ s, totalMoney}
				}
				);
			}
			else
			{
				if (!data[v].ContainsKey(s))
				{
					data[v].Add(s, totalMoney);
				}
				else
				{
					int temp = data[v].GetValueOrDefault(s);
					temp += totalMoney;
					data[v].Remove(s);
					data[v].Add(s, temp);
				}
			}
		}
	}
}
