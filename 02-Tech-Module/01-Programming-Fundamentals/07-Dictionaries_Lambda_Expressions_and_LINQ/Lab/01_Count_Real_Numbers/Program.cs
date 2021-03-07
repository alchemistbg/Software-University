using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

			SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

			foreach (double d in input)
			{
				if (!counts.Keys.Contains(d))
				{
					counts[d] = 1;
				}
				else
				{
					counts[d]++;
				}
			}

			foreach (var item in counts)
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}
			/*var test = input.GroupBy(x => x).Select(c => new { Key = c.Key, Value = c.Count() });

			foreach (var item in test.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{item.Key} -> {item.Value}");
			}*/
		}
	}
}
