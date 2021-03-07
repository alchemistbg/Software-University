using System;
using System.Numerics;

namespace _13_Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine(calcFactoriel(n));
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
	}
}
