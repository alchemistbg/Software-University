using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			double average = input.Average();

			List<int> greaterThanAv = new List<int>();
			foreach (int i in input)
			{
				if (i > average)
				{
					greaterThanAv.Add(i);
				}
			}

			if (greaterThanAv.Count == 0)
			{
				Console.WriteLine("No");
			}
			else
			{
				Console.WriteLine(string.Join(" ", greaterThanAv.OrderByDescending(x => x).Take(5)));
			}

		}
	}
}
