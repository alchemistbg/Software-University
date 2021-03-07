using System;

namespace _01_DayOf_Week
{
	class Program
	{
		static void Main(string[] args)
		{
			String[] daysOfWeek = {
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday"
			};

			int queryNumber = int.Parse(Console.ReadLine());
			try
			{
				Console.WriteLine(daysOfWeek[queryNumber - 1]);
			}
			catch (Exception)
			{
				Console.WriteLine("Invalid Day!");
			}
		}
	}
}
