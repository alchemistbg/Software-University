using System;

namespace _09_Multiply_Evens_By_Odds
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = Math.Abs(int.Parse(Console.ReadLine()));

			Console.WriteLine(getMultiple(num));
		}

		static int getSumOfEvenDigit(int num)
		{
			int evenSum = 0;
			while (num > 0)
			{
				int last = num % 10;
				if (last % 2 == 0)
				{
					evenSum += last;
				}
				num = num / 10;
			}
			return evenSum;
		}

		static int getSumOfOddDigit(int num)
		{
			int evenSum = 0;
			while (num > 0)
			{
				int last = num % 10;
				if (last % 2 != 0)
				{
					evenSum += last;
				}
				num = num / 10;
			}
			return evenSum;
		}

		static int getMultiple(int i)
		{
			int evenSum = getSumOfEvenDigit(i);
			int oddSum = getSumOfOddDigit(i);
			return evenSum * oddSum;
		}
	}
}
