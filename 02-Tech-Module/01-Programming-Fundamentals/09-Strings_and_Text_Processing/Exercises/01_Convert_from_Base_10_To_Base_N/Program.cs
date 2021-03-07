using System;

namespace _01_Convert_from_Base_10_To_Base_N
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int baseNumber = int.Parse(input.Split(' ')[0]);
			BigInteger number = BigInteger.Parse(input.Split(' ')[1]);

			List<BigInteger> convertedNumber = new List<BigInteger>();

			while (number > 0)
			{
				BigInteger residual = number % baseNumber;
				convertedNumber.Add(residual);
				number = number / baseNumber;
			}
			convertedNumber.Reverse();
			Console.WriteLine(string.Join("", convertedNumber));
		}
	}
}
