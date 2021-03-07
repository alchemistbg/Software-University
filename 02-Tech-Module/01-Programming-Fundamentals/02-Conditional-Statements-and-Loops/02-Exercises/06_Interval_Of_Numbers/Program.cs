using System;

namespace _06_Interval_Of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());

			//Much shorter approach with just one for loop and no if-else
			for (int i = Math.Min(num1, num2); i <= Math.Max(num1, num2); i++)
			{
				Console.WriteLine(i);
			}

			//if (num1 < num2)
			//{
			//	for (int i = num1; i <= num2; i++)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}
			//else
			//{
			//	for (int i = num2; i <= num1; i++)
			//	{
			//		Console.WriteLine(i);
			//	}
			//}
		}
	}
}
