using System;

namespace _05_Weather_Forecast
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			try
			{
				sbyte i = checked(sbyte.Parse(input));
				Console.WriteLine("Sunny");
				return;
			}
			catch (OverflowException)
			{

			}
			catch (System.FormatException)
			{

			}
			
			try
			{
				int i = checked(int.Parse(input));
				Console.WriteLine("Cloudy");
				return;
			}
			catch (OverflowException)
			{

			}
			catch (System.FormatException)
			{

			}

			try
			{
				long i = checked(long.Parse(input));
				Console.WriteLine("Windy");
				return;
			}
			catch (OverflowException)
			{

			}
			catch (System.FormatException)
			{

			}

			try
			{
				float i = checked(float.Parse(input));
				Console.WriteLine("Rainy");
				return;
			}
			catch (OverflowException)
			{

			}
		}
	}
}
