using System;

namespace _12_Master_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int upperLimit = int.Parse(Console.ReadLine());

			for (int i = 1; i <= upperLimit; i++)
			{
				if (isPalindrom(i) && isSumOfDigitDivisible(i) && isHoldEvenDigit(i))
				{
					Console.WriteLine(i);
				}
			}
		}

		static Boolean isPalindrom(int number)
		{
			string numberToCheck = number.ToString();

			for (int i = numberToCheck.Length - 1; i >= 0; i--)
			{
				if (numberToCheck[i] != numberToCheck[(numberToCheck.Length - 1) - i])
				{
					return false;
				}
			}
			return true;

		}

		static Boolean isSumOfDigitDivisible(int number)
		{
			int numberDigitSum = 0;
			string numString = number.ToString();
			for (int i = 0; i < numString.Length; i++)
			{
				numberDigitSum += int.Parse(numString[i].ToString());
			}

			if ((numberDigitSum % 7) == 0)
			{
				return true;
			}
			return false;
		}

		static Boolean isHoldEvenDigit(int number)
		{
			for (int i = number.ToString().Length - 1; i >= 0; i--)
			{
				int temp = (number % 10);
				if ((temp % 2) == 0)
				{
					return true;
				}
				number /= 10;
			}

			return false;
		}
	}
}
