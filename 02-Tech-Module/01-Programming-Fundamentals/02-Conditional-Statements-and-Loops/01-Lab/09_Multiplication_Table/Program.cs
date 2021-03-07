using System;

namespace _09_Multiplication_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int baseNumber = int.Parse(Console.ReadLine());

			for (int i = 1; i < 11; i++)
			{
				Console.WriteLine($"{baseNumber} X {i} = " + (baseNumber * i));
			}
		}
	}
}
