using System;

namespace _01_Day_Of_Week
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputDate = Console.ReadLine();
			DateTime dt = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine(dt.DayOfWeek);
		}
	}
}
