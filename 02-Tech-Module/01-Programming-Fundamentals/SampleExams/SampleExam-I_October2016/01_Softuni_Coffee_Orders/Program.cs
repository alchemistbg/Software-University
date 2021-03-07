using System;
using System.Globalization;

namespace _01_Softuni_Coffee_Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			int ordersCount = int.Parse(Console.ReadLine());

			decimal totalCoffeePrice = 0.0M;
			for (int i = 0; i < ordersCount; i++)
			{
				decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
				DateTime dt = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
				int daysInMonth = DateTime.DaysInMonth(dt.Year, dt.Month);
				long capsulesCount = long.Parse(Console.ReadLine());
				decimal singleCoffeePrice = (daysInMonth * capsulesCount) * pricePerCapsule;

				Console.WriteLine($"The price for the coffee is: ${singleCoffeePrice:F2}");

				totalCoffeePrice += singleCoffeePrice;
			}
			Console.WriteLine($"Total: ${totalCoffeePrice:F2}");
		}
	}
}
