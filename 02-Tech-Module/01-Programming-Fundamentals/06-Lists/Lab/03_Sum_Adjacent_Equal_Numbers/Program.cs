using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Sum_Adjacent_Equal_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<decimal> numbers = Console.ReadLine()
				.Split(' ')
				.Select(decimal.Parse)
				.ToList();

			recMethod(numbers);
			Console.WriteLine(string.Join(' ', numbers));
		}


		static void recMethod(List<decimal> someList)
		{
			for (int i = 0; i < someList.Count - 1; i++)
			{
				if (someList[i] == someList[i + 1])
				{
					decimal sum = someList[i] + someList[i + 1];
					someList.RemoveAt(i + 1);
					someList.RemoveAt(i);
					someList.Insert(i, sum);
					recMethod(someList);
				}
			}
		}
	}
}
