using System;

namespace _06_Prime_Checker
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong number = ulong.Parse(Console.ReadLine());
			Console.WriteLine(isPrime(number));
		}

		static Boolean isPrime(ulong number)
		{
			if (number < 2)
			{
				return false;
			}
			if (number > 1)
			{
				for (ulong i = 2; i <= Math.Sqrt(number); i++)
				{
					if (number % i == 0)
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
