using System;

namespace _02_Choose_A_Drink_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			string profession = Console.ReadLine();
			int qty = int.Parse(Console.ReadLine());

			double price = 0.0;

			switch (profession)
			{
				case "Athlete":
					price = qty * 0.7;
					break;
				case "Businessman":
				case "Businesswoman":
					price = qty * 1.0;
					break;
				case "SoftUni Student":
					price = qty * 1.7;
					break;
				default:
					price = qty * 1.2;
					break;
			}
			Console.WriteLine($"The {profession} has to pay {price:f02}.");
		}
	}
}
