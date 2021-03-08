using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Dragon_Army
{
	class Dragon
	{
		public string dragonName { get; set; }
		public string dragonType { get; set; }
		public int dragonDamage { get; set; }
		public int dragonHealth { get; set; }
		public int dragonArmor { get; set; }

		private string inputString = "";
		public Dragon(string input)
		{
			inputString = input;
			CreateDragon();
		}

		private void CreateDragon()
		{
			string[] dragonInfo = inputString.Split(" ");

			dragonType = dragonInfo[0];

			dragonName = dragonInfo[1];

			if (dragonInfo[2] == "null")
			{
				dragonDamage = 45;
			}
			else
			{
				dragonDamage = int.Parse(dragonInfo[2]);
			}

			if (dragonInfo[3] == "null")
			{
				dragonHealth = 250;
			}
			else
			{
				dragonHealth = int.Parse(dragonInfo[3]);
			}

			if (dragonInfo[4] == "null")
			{
				dragonArmor = 10;
			}
			else
			{
				dragonArmor = int.Parse(dragonInfo[4]);
			}
		}
	}

	class Program
	{
		static List<Dragon> dragonNest = new List<Dragon>();

		static void Main(string[] args)
		{

			int inputNum = int.Parse(Console.ReadLine());
			string[] input = new string[inputNum];

			for (int i = 0; i < inputNum; i++)
			{
				input[i] = Console.ReadLine();
			}

			foreach (var item in input)
			{
				Dragon d = new Dragon(item);
				addDragon(d);
			}

			printNestStatistics();
		}

		static void addDragon(Dragon d)
		{
			if (dragonNest.Count == 0)
			{
				dragonNest.Add(d);
			}
			else
			{
				string[] dragonTest = checkDuplicates(d);
				if (dragonTest[0] == "true")
				{
					int i = int.Parse(dragonTest[1]);
					dragonNest[i].dragonHealth = d.dragonHealth;
					dragonNest[i].dragonDamage = d.dragonDamage;
					dragonNest[i].dragonArmor = d.dragonArmor;
				}
				else
				{
					dragonNest.Add(d);
				}
			}
		}

		public static string[] checkDuplicates(Dragon d)
		{
			string[] result = new string[2];
			result[0] = "false";
			for (int i = 0; i < dragonNest.Count; i++)
			{
				if (dragonNest[i].dragonName == d.dragonName && dragonNest[i].dragonType == d.dragonType)
				{
					result[0] = "true";
					result[1] = "" + i;
				}
			}
			return result;
		}

		public static void printNestStatistics()
		{
			var result = dragonNest.GroupBy(x => x.dragonType).ToList();
			foreach (var item in result)
			{
				List<int> dD = item.ToList().Select(x => x.dragonDamage).ToList();
				List<int> dH = item.ToList().Select(x => x.dragonHealth).ToList();
				List<int> dA = item.ToList().Select(x => x.dragonArmor).ToList();
				Console.WriteLine($"{item.Key}::({calcAverage(dD)}/{calcAverage(dH)}/{calcAverage(dA)})");

				foreach (var item2 in item.OrderBy(x => x.dragonName))
				{
					Console.WriteLine($"-{item2.dragonName} -> damage: {item2.dragonDamage}, health: {item2.dragonHealth}, armor: {item2.dragonArmor}");
				}
			}
		}

		public static string calcAverage(List<int> list)
		{
			double average = 0.0;
			foreach (var item in list)
			{
				average += item;
			}
			average = average / list.Count;
			string s = $"{average:f2}";
			return s;
		}
	}
}
