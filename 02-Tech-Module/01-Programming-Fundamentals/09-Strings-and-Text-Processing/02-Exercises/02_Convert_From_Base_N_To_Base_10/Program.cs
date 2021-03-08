using System;
using System.Collections.Generic;
using System.Numerics;

namespace _02_Convert_From_Base_N_To_Base_10
{
	class Program
	{
		static void Main(string[] args)
		{
			String input = Console.ReadLine();
			int baseNumber = int.Parse(input.Split(' ')[0]);
			BigInteger number = BigInteger.Parse(input.Split(' ')[1]);

			BigInteger convertedNumber = 0;

			String numberToString = number.ToString();
			List<BigInteger> numberDigits = new List<BigInteger>();

			while (number > 0)
			{
				numberDigits.Add(number % 10);
				number /= 10;
			}

			for (int i = 0; i < numberDigits.Count; i++)
			{
				convertedNumber += numberDigits[i] * BigInteger.Pow(baseNumber, i);
			}
			Console.WriteLine(convertedNumber);
		}
	}
}
