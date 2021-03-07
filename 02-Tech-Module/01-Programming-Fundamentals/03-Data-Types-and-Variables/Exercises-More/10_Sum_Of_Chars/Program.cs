using System;

namespace _10_Sum_Of_Chars
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			int totalSum = 0;

			for (int i = 0; i < num; i++)
			{
				int charInt = (int)char.Parse(Console.ReadLine());
				totalSum += charInt;
			}

			Console.WriteLine($"The sum equals: {totalSum}");
		}
	}
}
