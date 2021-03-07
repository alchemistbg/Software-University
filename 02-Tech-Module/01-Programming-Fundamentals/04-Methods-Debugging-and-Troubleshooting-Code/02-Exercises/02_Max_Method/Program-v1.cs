using System;

namespace _02_Max_Method
{
	class Program_v1
	{
		//static void Main(string[] args)
		//{
		//    Console.WriteLine("Welcome!");

		//    int biggestNum = int.MinValue;

		//    int num1 = int.Parse(Console.ReadLine());
		//    int num2 = int.Parse(Console.ReadLine());
		//    int num3 = int.Parse(Console.ReadLine());

		//    biggestNum = getMax(biggestNum, num1);
		//    biggestNum = getMax(biggestNum, num2);
		//    biggestNum = getMax(biggestNum, num3);

		//    Console.WriteLine(biggestNum);
		//}

		static int getMax(int a, int b)
		{
			int bigger = int.MinValue;
			if (a > b)
			{
				bigger = a;
			}
			else
			{
				bigger = b;
			}
			return bigger;
		}
	}
}
