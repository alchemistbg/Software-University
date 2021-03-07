using System;

namespace _13_Game_Of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			int magicNumber = int.Parse(Console.ReadLine());

			int sum = 0;
			int counter = 0;

			int lastN = 0;
			int lastM = 0;

			for (int i = n; i <= m; i++)
			{
				for (int j = n; j <= m; j++)
				{
					sum = i + j;
					counter++;
					if (sum == magicNumber)
					{
						lastN = i;
						lastM = j;
					}
				}
			}
			if (lastN > 0 || lastM > 0)
			{
				Console.WriteLine($"Number found! {lastN} + {lastM} = {magicNumber}");
			}
			else
			{
				Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
			}
		}
	}
}
