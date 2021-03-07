using System;

namespace _01_Sweet_Dessert
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal cash = decimal.Parse(Console.ReadLine());
			int guests = int.Parse(Console.ReadLine());
			decimal bananaPrice = decimal.Parse(Console.ReadLine());
			decimal eggPrice = decimal.Parse(Console.ReadLine());
			decimal berryPrice = decimal.Parse(Console.ReadLine());

			decimal portions = Decimal.Ceiling(1.0M * guests/6);

			decimal totalBananaPrice = portions * bananaPrice * 2;
			decimal totalEggPrice = portions * eggPrice * 4;
			decimal totalBerryPrice = portions * berryPrice * 0.2M;
			decimal spendings = totalBananaPrice + totalEggPrice + totalBerryPrice;

			if (cash >= spendings)
			{
				Console.WriteLine($"Ivancho has enough money - it would cost {spendings:F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivancho will have to withdraw money - he will need {(spendings-cash):F2}lv more.");
			}
		}
	}
}
