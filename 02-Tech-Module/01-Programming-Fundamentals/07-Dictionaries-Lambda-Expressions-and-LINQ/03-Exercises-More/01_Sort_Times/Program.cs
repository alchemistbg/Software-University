using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Sort_Times
{
	class Program
	{
		static void Main(string[] args)
		{
			List<String> input = Console.ReadLine().Split(" ").ToList();
			input.Sort();
			Console.WriteLine(String.Join(", ", input));
		}
	}
}
