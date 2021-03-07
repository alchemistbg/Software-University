using System;

namespace _05_Fibonacci_Numbers
{
	class Program_v2
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(Fib(number));
		}

		private static int Fib(int n)
		{
			int fNumber = 0;
			if (n == 0 || n == 1)
			{
				fNumber = 1;
				return fNumber;
			}

			int fNumber_prev = 1;
			int fNumber_prevPrev = 1;
			for (int i = 2; i <= n; i++)
			{
				fNumber = fNumber_prev + fNumber_prevPrev;
				fNumber_prevPrev = fNumber_prev;
				fNumber_prev = fNumber;
			}
			return fNumber;
		}
	}
}
