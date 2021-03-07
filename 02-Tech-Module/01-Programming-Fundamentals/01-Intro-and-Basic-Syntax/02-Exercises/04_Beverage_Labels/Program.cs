using System;

namespace _04_Beverage_Labels
{
	class Program
	{
		static void Main(string[] args)
		{
			string beverageLabel = Console.ReadLine();
			int beverageVolume = int.Parse(Console.ReadLine());
			int energyPer100 = int.Parse(Console.ReadLine());
			int sugarPer100 = int.Parse(Console.ReadLine());

			double energyTotal = 1.0 * beverageVolume * energyPer100 / 100;
			double sugarTotal = 1.0 * beverageVolume * sugarPer100 / 100;

			Console.WriteLine($"{beverageVolume}ml {beverageLabel}:");
			Console.WriteLine($"{energyTotal}kcal, {sugarTotal}g sugars");
		}
	}
}
