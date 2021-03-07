using System;
using System.Linq;

namespace _01_Array_Statistics
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Console.WriteLine($"Min = {input.Min()}");
			Console.WriteLine($"Max = {input.Max()}");
			Console.WriteLine($"Sum = {input.Sum()}");
			Console.WriteLine($"Average = {input.Average()}");
		}
	}
}
