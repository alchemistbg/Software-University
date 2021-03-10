using System;

namespace _01_Sweet_Dessert
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal cash = decimal.Parse(Console.ReadLine());
			int guestsNumber = int.Parse(Console.ReadLine());
			decimal bananaPrice = decimal.Parse(Console.ReadLine());
			decimal eggPrice = decimal.Parse(Console.ReadLine());
			decimal berryPrice = decimal.Parse(Console.ReadLine());

			int desertDoses = (int)Math.Ceiling(1.0 * guestsNumber / 6);
			int totalBanana = 2 * desertDoses;
			int totalEggs = 4 * desertDoses;
			decimal totalBerries = 0.2M * desertDoses;

			decimal bill = bananaPrice * totalBanana + eggPrice * totalEggs + berryPrice * totalBerries;
			if (cash >= bill)
			{
				Console.WriteLine($"Ivancho has enough money - it would cost {bill:F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivancho will have to withdraw money - he will need {(bill - cash):F2}lv more.");
			}
		}
	}
}
