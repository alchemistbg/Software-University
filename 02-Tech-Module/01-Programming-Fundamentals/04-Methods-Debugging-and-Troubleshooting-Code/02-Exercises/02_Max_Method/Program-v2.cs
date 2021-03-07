using System;

namespace _02_Max_Method
{
	class Program_v2
	{
		static int biggestNum = int.MinValue;

		static void Main(string[] args)
		//static void abc(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			getMax(num1, num2);
			getMax(num1, num3);
			getMax(num2, num3);

			Console.WriteLine(biggestNum);
		}

		static void getMax(int a, int b)
		{
			if (a > biggestNum)
			{
				biggestNum = a;
			}

			if (b > biggestNum)
			{
				biggestNum = b;
			}
		}
	}
}
