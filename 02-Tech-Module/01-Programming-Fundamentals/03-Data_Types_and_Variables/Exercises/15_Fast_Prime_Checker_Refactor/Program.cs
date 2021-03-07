using System;

namespace _15_Fast_Prime_Checker_Refactor
{
	class Program
	{
		static void Main(string[] args)
		{
			int numberToCheck = int.Parse(Console.ReadLine());
			for (int i = 2; i <= numberToCheck; i++)
			{
				bool isPrime = true;
				for (int devider = 2; devider <= Math.Sqrt(i); devider++)
				{
					if (i % devider == 0)
					{
						isPrime = false;
						break;
					}
				}
				Console.WriteLine($"{i} -> {isPrime}");
			}
		}
	}
}
