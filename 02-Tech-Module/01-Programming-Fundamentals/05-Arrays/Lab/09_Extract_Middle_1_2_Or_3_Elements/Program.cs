using System;

namespace _09_Extract_Middle_1_2_Or_3_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int n = numArray.Length;

			if (n == 1)
			{
				Console.WriteLine(numArray[0]);
			}
			else if (n % 2 == 0)
			{
				Console.WriteLine($"{{ {numArray[n / 2 - 1]}, {numArray[n / 2]} }}");
			}
			else
			{
				Console.WriteLine($"{{ {numArray[n / 2 - 1]}, {numArray[n / 2]}, {numArray[n / 2 + 1]} }}");
			}
		}
	}
}
