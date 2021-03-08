using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_Legendary_Farming
{
	class Program
	{
		static Dictionary<string, String> heroes = new Dictionary<string, String>() {
			{ "fragments", "Valanyr"},
			{ "shards", "Shadowmourne"},
			{ "motes", "Dragonwrath"}
		};

		static Dictionary<String, int> keyMat = new Dictionary<string, int>() {
			{ "fragments", 0},
			{ "shards", 0},
			{ "motes", 0}
		};

		static Dictionary<String, int> junkMat = new Dictionary<string, int>();
		static bool heroReady = false;
		static string hero = "";

		static void Main(string[] args)
		{
			string input = Console.ReadLine().ToLower();
			addData(input);

			while (!heroReady)
			{
				input = Console.ReadLine().ToLower();
				addData(input);
			}

			printer();
		}

		static void addData(string input)
		{
			string[] inputArr = input.Split(" ");
			string material = "";
			int qty = 0;

			for (int i = 0; i < inputArr.Length; i += 2)
			{
				qty = int.Parse(inputArr[i]);
				material = inputArr[i + 1];

				if (isKeyMat(material))
				{
					keyMat[material] = keyMat[material] + qty;

					if (isHeroReady())
					{
						break;
					}
				}
				else
				{
					if (!junkMat.ContainsKey(material))
					{
						junkMat.Add(material, qty);
					}
					else
					{
						junkMat[material] = junkMat[material] + qty;
					}
				}

			}
		}

		private static bool isKeyMat(String mat)
		{
			bool b = false;
			if (keyMat.ContainsKey(mat))
			{
				b = true;
			}
			return b;
		}

		private static bool isHeroReady()
		{
			string temp = "";
			foreach (var item in keyMat)
			{
				if (item.Value >= 250)
				{
					heroReady = true;
					hero = heroes[item.Key];
					temp = item.Key;
				}
			}
			if (heroReady)
			{
				keyMat[temp] = keyMat[temp] - 250;
			}

			return heroReady;
		}

		static void printer()
		{
			Console.WriteLine($"{hero} obtained!");
			foreach (var item in keyMat.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
			foreach (var item in junkMat.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{item.Key}: {item.Value}");
			}
		}
	}
}
