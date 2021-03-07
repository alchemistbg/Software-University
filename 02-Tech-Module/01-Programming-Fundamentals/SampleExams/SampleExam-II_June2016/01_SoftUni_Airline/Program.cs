using System;

namespace _01_SoftUni_Airline
{
	class Program
	{
		static void Main(string[] args)
		{
			int flightsNumber = int.Parse(Console.ReadLine());

			decimal totalIncome = 0.0M;
			for (int i = 0; i < flightsNumber; i++)
			{
				int adultCount = int.Parse(Console.ReadLine());
				decimal adultPrice = decimal.Parse(Console.ReadLine());
				int youthCount = int.Parse(Console.ReadLine());
				decimal youthPrice = decimal.Parse(Console.ReadLine());
				decimal ticketsIncome = adultPrice * adultCount + youthPrice * youthCount;

				decimal fuelPrice = decimal.Parse(Console.ReadLine());
				decimal fuelConsumption = decimal.Parse(Console.ReadLine());
				decimal flightDuration = decimal.Parse(Console.ReadLine());
				decimal fuelExpenses = fuelPrice * fuelConsumption * flightDuration;

				decimal flightIncome = ticketsIncome - fuelExpenses;
				if (flightIncome >= 0)
				{
					Console.WriteLine($"You are ahead with {flightIncome:F3}$.");
				}
				else
				{
					Console.WriteLine($"We've got to sell more tickets! We've lost -{Math.Abs(flightIncome):F3}$.");
				}
				totalIncome += flightIncome;
			}
			Console.WriteLine($"Overall profit -> {totalIncome:F3}$.");
			Console.WriteLine($"Average profit -> {totalIncome / flightsNumber:F3}$.");
		}
	}
}
