using System;

namespace _03_Back_in_30_Minutes
{
	class Program
	{
		static void Main(string[] args)
		{
			int hoursNow = int.Parse(Console.ReadLine());
			int minutesNow = int.Parse(Console.ReadLine());

			int hoursLater = 0;
			int minutesLater = 0;

			if (minutesNow >= 30)
			{
				minutesLater = minutesNow - 30;
				hoursLater = hoursNow + 1;
			}
			else
			{
				minutesLater = minutesNow + 30;
				hoursLater = hoursNow;
			}

			if (hoursLater >= 24)
			{
				hoursLater = hoursLater - 24;
			}

			Console.WriteLine($"{hoursLater}:{minutesLater:D2}");
		}
	}
}
