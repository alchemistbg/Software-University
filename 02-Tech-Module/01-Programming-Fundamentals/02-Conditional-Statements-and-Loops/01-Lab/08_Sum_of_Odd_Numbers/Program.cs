using System;

namespace _08_Sum_of_Odd_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());
			int number = 1;
			Console.WriteLine(number);
			int sum = number;
			for (int i = 0; i < counter - 1; i++)
			{
				number += 2;
				Console.WriteLine(number);
				sum = sum + number;
			}
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
