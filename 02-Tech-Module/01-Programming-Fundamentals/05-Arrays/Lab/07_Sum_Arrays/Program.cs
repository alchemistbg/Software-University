using System;
using System.Linq;

namespace _07_Sum_Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] input2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int[] result = new int[Math.Max(input1.Length, input2.Length)];

			for (int i = 0; i < result.Length; i++)
			{
				result[i] = input1[i % input1.Length] + input2[i % input2.Length];
			}

			Console.WriteLine(string.Join(' ', result));
		}
	}
}
