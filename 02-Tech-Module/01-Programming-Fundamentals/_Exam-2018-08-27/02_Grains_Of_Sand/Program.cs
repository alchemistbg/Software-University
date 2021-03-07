using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Grains_Of_Sand
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> grains = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

			string command = Console.ReadLine();
			while (command != "Mort")
			{
				string[] commArr = command.Split(' ');
				if (commArr.Length == 2)
				{
					long value = long.Parse(commArr[1]);
					if (commArr[0] == "Add")
					{
						grains.Add(value);
					}
					else if (commArr[0] == "Remove")
					{
						if (grains.Contains(value))
						{
							grains.Remove(value);
						}
						else
						{
							if (value >= 0 && value < grains.Count)
							{
								grains.RemoveAt((int)value);
							}
						}
					}
					else if (commArr[0] == "Increase")
					{
						long increaseValue = grains[grains.Count - 1];

						for (int i = 0; i < grains.Count; i++)
						{
							if (grains[i] >= value)
							{
								increaseValue = grains[i];
								break;
							}
						}

						for (int i = 0; i < grains.Count; i++)
						{
							grains[i] += increaseValue;
						}
					}
					else if (commArr[0] == "Collapse")
					{
						grains.RemoveAll(x => x < value);
					}
				}
				else
				{
					if (commArr[0] == "Replace")
					{
						long valueToReplace = long.Parse(commArr[1]);
						long replacementValue = long.Parse(commArr[2]);
						if (grains.Contains(valueToReplace))
						{
							int valueToReplaceIndex = (int)grains.IndexOf(valueToReplace);
							grains[valueToReplaceIndex] = replacementValue;
						}
					}
				}
				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", grains));
		}
	}
}
