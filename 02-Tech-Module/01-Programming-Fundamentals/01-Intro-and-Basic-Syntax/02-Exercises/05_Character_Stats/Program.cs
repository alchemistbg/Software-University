using System;

namespace _05_Character_Stats
{
	class Program
	{
		static void Main(string[] args)
		{
			string heroName = Console.ReadLine();
			int healtNow = int.Parse(Console.ReadLine());
			int healtTotal = int.Parse(Console.ReadLine());
			int energyNow = int.Parse(Console.ReadLine());
			int energyTotal = int.Parse(Console.ReadLine());

			string healthStatus = "|" + new String('|', healtNow) + new String('.', healtTotal - healtNow) + "|";
			string energyStatus = "|" + new String('|', energyNow) + new String('.', energyTotal - energyNow) + "|";

			Console.WriteLine($"Name: {heroName}");
			Console.WriteLine($"Health: {healthStatus}");
			Console.WriteLine($"Energy: {energyStatus}");
		}
	}
}
