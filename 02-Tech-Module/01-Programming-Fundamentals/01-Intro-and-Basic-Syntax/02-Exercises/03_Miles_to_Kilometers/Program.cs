using System;

namespace _03_Miles_to_Kilometers
{
	class Program
	{
		static void Main(string[] args)
		{
			double miles = double.Parse(Console.ReadLine());
			double kilometres = miles * 1.60934;
			Console.WriteLine($"{kilometres:f2}");
		}
	}
}
