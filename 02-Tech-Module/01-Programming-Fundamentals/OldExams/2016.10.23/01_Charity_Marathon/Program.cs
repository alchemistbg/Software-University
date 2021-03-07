using System;

namespace _01_Charity_Marathon
{
	class Program
	{
		static void Main(string[] args)
		{
			int days = int.Parse(Console.ReadLine());
			int totalRunners = int.Parse(Console.ReadLine());
			decimal lapsPerRunner = decimal.Parse(Console.ReadLine());
			int trackLength = int.Parse(Console.ReadLine());
			int trackCapacity = int.Parse(Console.ReadLine());
			if (days * trackCapacity < totalRunners)
			{
				totalRunners = days * trackCapacity;
			}
			decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

			decimal totalMoney = moneyPerKilometer * trackLength * lapsPerRunner * totalRunners / 1000;

			Console.WriteLine($"Money raised: {totalMoney:F2}");
		}
	}
}
