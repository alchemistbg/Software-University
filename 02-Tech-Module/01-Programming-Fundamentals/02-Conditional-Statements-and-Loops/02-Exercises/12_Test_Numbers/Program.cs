using System;

namespace _12_Test_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int sumMax = int.Parse(Console.ReadLine());

			int sum = 0;
			int counter = 0;

			for (int i = n; i >= 1; i--)
			{
				for (int k = 1; k <= m; k++)
				{
					sum += i * k * 3;
					counter++;

					if (sum >= sumMax)
					{
						Console.WriteLine($"{counter} combinations");
						Console.WriteLine($"Sum: {sum} >= {sumMax}");
						return;
					}
				}
			}
			Console.WriteLine($"{counter} combinations");
			Console.WriteLine($"Sum: {sum}");
		}
	}
}
