using System;

namespace _01_Padawan_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal money = decimal.Parse(Console.ReadLine());
			int students = int.Parse(Console.ReadLine());
			decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
			decimal robePrice = decimal.Parse(Console.ReadLine());
			decimal beltPrice = decimal.Parse(Console.ReadLine());

			decimal totalSpending = 0.0M;
			totalSpending += (Decimal.Ceiling((students * 1.1M))) * lightsaberPrice;
			totalSpending += students * robePrice;
			totalSpending += (students - (students / 6)) * beltPrice;

			if (money >= totalSpending)
			{
				Console.WriteLine($"The money is enough - it would cost {totalSpending:F2}lv.");
			}
			else
			{
				Console.WriteLine($"Ivan Cho will need {(totalSpending - money):F2}lv more.");
			}
		}
	}
}
