using System;

namespace _07_Training_Hall_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal budget = decimal.Parse(Console.ReadLine());
			int shopList = int.Parse(Console.ReadLine());

			decimal currentSum = 0.0m;

			for (int i = 0; i < shopList * 3; i += 3)
			{
				string itemName = Console.ReadLine();
				decimal itemPrice = decimal.Parse(Console.ReadLine());
				int itemQty = int.Parse(Console.ReadLine());

				if (itemQty > 1)
				{
					Console.WriteLine($"Adding {itemQty} {itemName + "s"} to cart.");
				}
				else
				{
					Console.WriteLine($"Adding {itemQty} {itemName} to cart.");
				}
				currentSum += itemQty * itemPrice;
			}
			Console.WriteLine($"Subtotal: ${currentSum:f2}");

			decimal diff = budget - currentSum;
			if (diff < 0)
			{
				diff = diff * -1m;
			}

			if (budget >= currentSum)
			{
				Console.WriteLine($"Money left: ${diff:f2}");
			}
			else
			{
				Console.WriteLine($"Not enough. We need ${diff} more.");
			}
		}
	}
}
