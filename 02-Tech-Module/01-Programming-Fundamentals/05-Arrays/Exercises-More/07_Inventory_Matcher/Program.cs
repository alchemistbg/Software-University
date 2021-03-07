using System;

namespace _07_Inventory_Matcher
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] products = Console.ReadLine().Split(' ');
			long[] qty = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

			string input = Console.ReadLine();
			while (input != "done")
			{
				int index = Array.IndexOf(products, input);

				Console.WriteLine($"{input} costs: {prices[index].ToString()}; Available quantity: {qty[index]}");
				input = Console.ReadLine();
			}
		}
	}
}
