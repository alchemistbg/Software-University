using System;

namespace _04_Hotel
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int nights = int.Parse(Console.ReadLine());

			decimal studioPrice = 0.0m;
			decimal doublePrice = 0.0m;
			decimal suitePrice = 0.0m;

			if (month.Equals("May") || month.Equals("October"))
			{
				studioPrice = nights * 50m;
				doublePrice = nights * 65m;
				suitePrice = nights * 75m;
			}
			else if (month.Equals("June") || month.Equals("September"))
			{
				studioPrice = nights * 60m;
				doublePrice = nights * 72m;
				suitePrice = nights * 82m;
			}
			else
			{
				studioPrice = nights * 68m;
				doublePrice = nights * 77m;
				suitePrice = nights * 89m;
			}

			if ((month.Equals("May") || month.Equals("October")) && nights > 7)
			{
				studioPrice = studioPrice * 0.95m;
			}

			if ((month.Equals("June") || month.Equals("September")) && nights > 14)
			{
				doublePrice = doublePrice * 0.90m;
			}

			if ((month.Equals("July") || month.Equals("August") || month.Equals("December")) && nights > 14)
			{
				suitePrice = suitePrice * 0.85m;
			}

			if ((month.Equals("September") || month.Equals("October")) && nights > 7)
			{
				decimal pricePerNigth = studioPrice / nights;
				studioPrice = studioPrice - pricePerNigth;
			}

			Console.WriteLine($"Studio: {studioPrice:F2} lv.");
			Console.WriteLine($"Double: {doublePrice:F2} lv.");
			Console.WriteLine($"Suite: {suitePrice:F2} lv.");
		}
	}
}
