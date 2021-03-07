using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Hornet_Armada
{
	class Program
	{
		static void Main(string[] args)
		{
			int rows = int.Parse(Console.ReadLine());

			List<Legion> legions = new List<Legion>();

			for (int i = 0; i < rows; i++)
			{
				string[] inputArr = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				long activity = long.Parse(inputArr[0]);
				string name = inputArr[1];
				string soldierType = inputArr[2];
				long soldierCount = long.Parse(inputArr[3]);

				int legionIndex = legions.FindIndex(x => x.Name == name);
				if (legionIndex < 0)
				{
					Legion legion = new Legion();
					legion.Name = name;
					legion.Activity = activity;
					legion.Soldiers.Add(soldierType, soldierCount);
					legions.Add(legion);
				}
				else
				{
					if (legions[legionIndex].Activity < activity)
					{
						legions[legionIndex].Activity = activity;
					}

					if (!legions[legionIndex].Soldiers.ContainsKey(soldierType))
					{
						legions[legionIndex].Soldiers[soldierType] = soldierCount;
					}
					else
					{
						legions[legionIndex].Soldiers[soldierType] += soldierCount;
					}
				}
			}

			string toPrint = Console.ReadLine();
			if (toPrint.Contains("\\"))
			{
				string[] toPrintArr = toPrint.Split('\\');
				long actFilter = long.Parse(toPrintArr[0]);
				string typeFilter = toPrintArr[1];

				foreach (var legion in legions.Where(x => x.Activity < actFilter && x.Soldiers.Keys.Contains(typeFilter)).OrderByDescending(x => x.Soldiers[typeFilter]))
				{
					Console.WriteLine($"{legion.Name} -> {legion.Soldiers[typeFilter]}");
				}
			}
			else
			{
				foreach (var legion in legions.Where(x => x.Soldiers.Keys.Contains(toPrint)).OrderByDescending(x => x.Activity))
				{
					Console.WriteLine($"{legion.Activity} : {legion.Name}");
				}
			}
		}
	}

	class Legion
	{
		public string Name { get; set; }
		public long Activity { get; set; }
		public Dictionary<string, long> Soldiers { get; set; }

		public Legion()
		{
			Soldiers = new Dictionary<string, long>();
		}
	}
}
