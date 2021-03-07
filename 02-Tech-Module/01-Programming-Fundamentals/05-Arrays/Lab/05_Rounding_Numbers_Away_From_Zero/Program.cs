using System;
using System.Linq;

namespace _05_Rounding_Numbers_Away_From_Zero
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] dArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

			foreach (double d in dArray)
			{
				Console.WriteLine($"{d} => {Math.Round(d, 0, MidpointRounding.AwayFromZero)}");
			}
		}
	}
}
