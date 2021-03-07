using System;
using System.Collections.Generic;

namespace _02_SoftUni_Water_Supplies
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> emptyBottles = new List<int>();
			double totalWater = double.Parse(Console.ReadLine());
			double[] bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double bottleCapacity = double.Parse(Console.ReadLine());

			if (totalWater % 2 == 0)
			{
				for (int i = 0; i < bottles.Length; i++)
				{
					double neededWater = bottleCapacity - bottles[i];
					if (totalWater < neededWater)
					{
						emptyBottles.Add(i);
					}
					totalWater -= neededWater;
				}
			}
			else
			{
				for (int i = bottles.Length - 1; i >= 0; i--)
				{
					double neededWater = bottleCapacity - bottles[i];
					if (totalWater < neededWater)
					{
						emptyBottles.Add(i);
					}
					totalWater -= neededWater;
				}
			}

			if (totalWater >= 0)
			{
				Console.WriteLine($"Enough water!\r\nWater left: {totalWater}l.");
			}
			else
			{
				Console.WriteLine("We need more water!");
				Console.WriteLine($"Bottles left: {emptyBottles.Count}");
				Console.WriteLine($"With indexes: {string.Join(", ", emptyBottles)}");
				Console.WriteLine($"We need {Math.Abs(totalWater)} more liters!");
			}
		}
	}
}
