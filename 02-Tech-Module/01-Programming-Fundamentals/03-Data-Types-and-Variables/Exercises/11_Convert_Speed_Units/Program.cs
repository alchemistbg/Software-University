using System;

namespace _11_Convert_Speed_Units
{
	class Program
	{
		static void Main(string[] args)
		{
			int meters = int.Parse(Console.ReadLine());
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int seconds = int.Parse(Console.ReadLine());
			
			int minutesTotal = hours * 60 + minutes;
			int secondsTotal = minutesTotal * 60 + seconds;

			float metersPerSecond = (float)meters / secondsTotal;
			float kMetersPerHour = ((float)(meters / 1000) / ((float)secondsTotal / 3600));
			float milesPerHour = kMetersPerHour / (float)1.609;
			Console.WriteLine(String.Format("{0:0.######}", metersPerSecond));
			Console.WriteLine(String.Format("{0:0.######}", kMetersPerHour));
			Console.WriteLine(String.Format("{0:0.######}", milesPerHour));
		}
	}
}
