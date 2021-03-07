using System;

namespace _12_Number_Checker
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int number = int.Parse(Console.ReadLine());
				Console.WriteLine("It is a number.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Invalid input!");
			}
		}
	}
}
