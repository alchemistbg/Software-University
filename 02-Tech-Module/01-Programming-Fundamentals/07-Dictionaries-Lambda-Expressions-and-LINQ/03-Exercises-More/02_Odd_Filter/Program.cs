using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Odd_Filter
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			List<int> evenList = new List<int>();
			foreach (int i in input)
			{
				if (i % 2 == 0)
				{
					evenList.Add(i);
				}
			}

			double evenAverage = evenList.Average();

			for (int i = 0; i < evenList.Count; i++)
			{
				if (evenList[i] > evenAverage)
				{
					evenList[i]++;
				}
				else
				{
					evenList[i]--;
				}
			}

			Console.WriteLine(String.Join(" ", evenList));
		}
	}
}
