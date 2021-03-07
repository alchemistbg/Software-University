using System;

namespace _08_Upgraded_Matcher
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
				string productName = input.Split(' ')[0];
				long productQty = long.Parse(input.Split(' ')[1]);

				long index = Array.IndexOf(products, productName);

				if (index > qty.Length - 1 || productQty > qty[index])
				{
					Console.WriteLine($"We do not have enough {products[index]}");
				}
				else
				{
					Console.WriteLine($"{products[index]} x {productQty} costs {productQty * prices[index]:F2}");
					qty[index] -= productQty;
				}
				input = Console.ReadLine();
			}
		}
	}
}
