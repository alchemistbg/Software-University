using System;

namespace _11_Odd_Number
{
	class Program
	{
		static void Main(string[] args)
		{

			int number;
			do
			{
				number = int.Parse(Console.ReadLine());
				if (number % 2 == 0)
				{
					Console.WriteLine("Please write an odd number.");
				}
				else
				{
					Console.WriteLine($"The number is: " + Math.Abs(number));
				}
			} while (number % 2 == 0);
		}
	}
}
