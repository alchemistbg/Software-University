using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Snowmen
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> snowmen = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

			while (snowmen.Count > 1)
			{
				List<int> beaten = new List<int>();
				for (int i = 0; i < snowmen.Count; i++)
				{
					int attackerIndex = i;
					int defenderIndex = snowmen[i] % snowmen.Count;

					if (snowmen.Where(x => x!= -1).Count() == 1)
					{
						break;
					}

					if (snowmen[attackerIndex] != -1)
					{
						int diff = Math.Abs(attackerIndex - defenderIndex);
						if (diff == 0)
						{
							Console.WriteLine($"{attackerIndex} performed harakiri");
							snowmen[attackerIndex] = -1;
						}
						else
						{
							if (diff % 2 == 0)
							{
								Console.WriteLine($"{attackerIndex} x {defenderIndex} -> {attackerIndex} wins");
								snowmen[defenderIndex] = -1;
							}
							else
							{
								Console.WriteLine($"{attackerIndex} x {defenderIndex} -> {defenderIndex} wins");
								snowmen[attackerIndex] = -1;
							}
						}
					}
				}
				snowmen = snowmen.Where(x => x != -1).ToList();
			}
		}
	}
}
