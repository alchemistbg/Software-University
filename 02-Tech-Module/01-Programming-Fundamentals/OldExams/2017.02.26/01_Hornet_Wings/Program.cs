using System;

namespace _01_Hornet_Wings
{
	class Program
	{
		static void Main(string[] args)
		{
			int wingFlaps = int.Parse(Console.ReadLine());
			decimal distance = decimal.Parse(Console.ReadLine());
			int endurance = int.Parse(Console.ReadLine());

			decimal totalDistance = 1.0M * wingFlaps / 1000 * distance;
			decimal totalTime = (1.0M * wingFlaps / 100) + (wingFlaps / endurance * 5);
			Console.WriteLine($"{totalDistance:F2} m.");
			Console.WriteLine($"{totalTime:F0} s.");
		}
	}
}
