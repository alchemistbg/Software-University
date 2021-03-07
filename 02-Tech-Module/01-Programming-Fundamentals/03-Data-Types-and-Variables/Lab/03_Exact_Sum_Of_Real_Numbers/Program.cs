using System;

namespace _03_Exact_Sum_Of_Real_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal sum = 0m;
			int repeats = int.Parse(Console.ReadLine());
			for (int i = 0; i < repeats; i++)
			{
				sum += decimal.Parse(Console.ReadLine());
			}
			Console.WriteLine(sum);
		}
	}
}
