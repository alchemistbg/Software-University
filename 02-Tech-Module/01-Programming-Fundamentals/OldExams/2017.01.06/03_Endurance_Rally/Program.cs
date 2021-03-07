using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Endurance_Rally
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, double> drivers = new Dictionary<string, double>();
			Dictionary<int, double> trackLayout = new Dictionary<int, double>();

			string input = Console.ReadLine();
			if (input.Length == 0)
			{
				return;
			}
			List<string> names = input.Split(' ').Select(x => x.Trim()).ToList();

			foreach (string name in names)
			{
				drivers[name] = name[0];
			}

			double[] zones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
			for (int i = 0; i < zones.Length; i++)
			{
				trackLayout[i] = zones[i];
			}

			long[] checkpoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

			for (int i = 0; i < names.Count; i++)
			{
				for (int j = 0; j < trackLayout.Count; j++)
				{
					if (!checkpoints.Contains(j))
					{
						drivers[names[i]] = drivers[names[i]] - trackLayout[j];
					}
					else
					{
						drivers[names[i]] = drivers[names[i]] + trackLayout[j];
					}

					if (drivers[names[i]] <= 0)
					{
						Console.WriteLine($"{drivers.Keys.ToList()[i]} - reached {j}");
						break;
					}
				}
				if (drivers[names[i]] > 0)
				{
					Console.WriteLine($"{drivers.Keys.ToList()[i]} - fuel left {drivers[names[i]]:F2}");
				}

			}

		}
	}
}
