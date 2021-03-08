using System;
using System.Collections.Generic;

namespace _03_Sum_Min_Max_Average
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			List<int> intList = new List<int>();
			for (int i = 0; i < n; i++)
			{
				intList.Add(int.Parse(Console.ReadLine()));
			}

			Console.WriteLine($"Sum = {intList.Sum()}");
			Console.WriteLine($"Min = {intList.Min()}");
			Console.WriteLine($"Max = {intList.Max()}");
			Console.WriteLine($"Average = {intList.Average()}");
			//foreach (int i in intList)
			//{
			//	Console.WriteLine(i);
			//}
		}
	}
}
