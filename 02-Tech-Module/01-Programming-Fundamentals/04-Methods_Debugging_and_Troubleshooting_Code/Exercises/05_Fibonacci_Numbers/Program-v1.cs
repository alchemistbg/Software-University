using System;

namespace _05_Fibonacci_Numbers
{
	class Program_v1
	{
		//static void Main(string[] args)
		//{
		//	int number = int.Parse(Console.ReadLine());
		//	Console.WriteLine(Fib(number));
		//}

		private static int Fib(int n)
		{
			int fibonacciNumber = 0;
			if (n == -1)
			{
				//Console.WriteLine(fibonacciNumber);
			}
			else
			{
				if (n == 0 || n == 1)
				{
					fibonacciNumber += 1;
					n--;
				}
				else
				{
					fibonacciNumber = Fib(n - 1) + Fib(n - 2);
				}
			}
			return fibonacciNumber;
		}
	}
}
