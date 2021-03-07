using System;

namespace _04_Tourist_Information
{
	class Program
	{
		static void Main(string[] args)
		{
			string measurement = Console.ReadLine();
			double numToConvert = double.Parse(Console.ReadLine());

			double result = 0.0;
			switch (measurement)
			{
				case "miles":
					result = numToConvert * 1.6;
					Console.WriteLine($"{numToConvert} {measurement} = {result:f2} kilometers");
					break;
				case "inches":
					result = numToConvert * 2.54;
					Console.WriteLine($"{numToConvert} {measurement} = {result:f2} centimeters");
					break;
				case "feet":
					result = numToConvert * 30;
					Console.WriteLine($"{numToConvert} {measurement} = {result:f2} centimeters");
					break;
				case "yards":
					result = numToConvert * 0.91;
					Console.WriteLine($"{numToConvert} {measurement} = {result:f2} meters");
					break;
				case "gallons":
					result = numToConvert * 3.8;
					Console.WriteLine($"{numToConvert} {measurement} = {result:f2} liters");
					break;
				default:
					break;
			}
		}
	}
}
