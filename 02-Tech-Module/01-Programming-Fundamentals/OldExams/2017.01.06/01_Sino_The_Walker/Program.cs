using System;
using System.Globalization;

namespace _01_Sino_The_Walker
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
			int feets = int.Parse(Console.ReadLine());
			int secondsPerFeet = int.Parse(Console.ReadLine());
			long totalTimeInSeconds = Math.BigMul(feets, secondsPerFeet);
			totalTimeInSeconds = totalTimeInSeconds % 86400;
			time = time.AddSeconds(totalTimeInSeconds);
			Console.WriteLine($"Time Arrival: {time.TimeOfDay}");
		}
	}
}
