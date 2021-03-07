using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Hornet_Assault
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> beehives = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
			List<long> hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

			List<long> survivalBeehives = new List<long>();

			for (int i = 0; i < beehives.Count; i++)
			{
				long hornetsPower = hornets.Sum();
				if (beehives[i] >= hornetsPower)
				{
					if (beehives[i] - hornetsPower > 0)
					{
						survivalBeehives.Add(beehives[i] - hornetsPower);
					}

					if (hornets.Count > 0)
					{
						hornets.RemoveAt(0);
					}
				}
			}

			if (survivalBeehives.Count > 0)
			{
				Console.WriteLine(string.Join(" ", survivalBeehives));
			}
			else
			{
				if (hornets.Count > 0)
				{

					Console.WriteLine(string.Join(" ", hornets));
				}
			}

		}
	}
}
