using System;
using System.Globalization;

namespace _02_Softuni_Coffee_Orders
{
	class Program
	{
		static void Main(string[] args)
		{
			int orders = int.Parse(Console.ReadLine());

			decimal totalSum = 0.0M;

			for (int i = 0; i < orders; i++)
			{
				decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
				DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
				int days = DateTime.DaysInMonth(date.Year, date.Month);
				int capsules = int.Parse(Console.ReadLine());
				decimal currentSum = (pricePerCapsule * days) * capsules;

				totalSum += currentSum;
				Console.WriteLine($"The price for the coffee is: ${currentSum:F2}");
			}

			Console.WriteLine($"Total: ${totalSum:F2}");
		}
	}
}
