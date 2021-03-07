using System;

namespace _05_Temperature_Conversion
{
	class Program
	{
		static void Main(string[] args)
		{
			double tempFahrenheit = double.Parse(Console.ReadLine());

			double tempCelsius = tempConvertor(tempFahrenheit);

			Console.WriteLine($"{tempCelsius:f2}");
		}

		static double tempConvertor(double tempF)
		{
			double tempC = (tempF - 32) * 5 / 9;
			return tempC;
		}
	}
}
