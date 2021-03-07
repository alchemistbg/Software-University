using System;

namespace _05_Sort_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<decimal> list = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
			list.Sort();
			Console.Write(list.ElementAt(0));
			for (int i = 1; i < list.Count; i++)
			{
				Console.Write($" <= {list.ElementAt(i)}");
			}
			Console.WriteLine();
		}
	}
}
