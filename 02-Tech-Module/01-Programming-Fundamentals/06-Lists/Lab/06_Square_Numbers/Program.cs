using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Square_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			List<int> result = new List<int>();

			for (int i = 0; i < input.Count; i++)
			{
				double sqrt = Math.Sqrt(input[i]);
				if (sqrt == (int)Math.Sqrt(input[i]))
				{
					result.Add(input[i]);
				}
			}

			result.Sort();
			result.Reverse();
			Console.WriteLine(string.Join(' ', result));

		}
	}
}
