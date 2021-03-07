using System;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroes
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			Console.WriteLine(countZeros(calcFactoriel(n)));
		}

		static BigInteger calcFactoriel(int n)
		{
			BigInteger factoriel = 1;
			for (int i = 1; i <= n; i++)
			{
				factoriel *= i;
			}
			return factoriel;
		}

		static int countZeros(BigInteger bi)
		{
			int zeros = 0;
			String biString = bi.ToString();
			for (int i = biString.Length - 1; i >= 0; i--)
			{
				if (biString[i].Equals('0'))
				{
					zeros++;
				}
				else
				{
					break;
				}
			}
			return zeros;
		}
	}
}
