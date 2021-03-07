using System;

namespace _09_Refactor_Special_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int maxNumber = int.Parse(Console.ReadLine());
			for (int i = 1; i <= maxNumber; i++)
			{
				int current = i;
				int sum = 0;
				while (i > 0)
				{
					sum += i % 10;
					i = i / 10;
				}
				bool isSpecial = false;
				isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
				Console.WriteLine($"{current} -> {isSpecial}");
				sum = 0;
				i = current;
			}
		}
	}
}
