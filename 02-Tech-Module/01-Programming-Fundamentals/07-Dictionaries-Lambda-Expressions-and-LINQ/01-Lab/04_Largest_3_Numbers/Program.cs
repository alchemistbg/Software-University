using System;
using System.Linq;

namespace _04_Largest_3_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray().OrderByDescending(x => x).Take(3).ToArray();

			//var top = intArray.OrderByDescending(x => x).Take(3);
			Console.WriteLine(string.Join(' ', intArray));
		}
	}
}
