﻿using System;
using System.Collections.Generic;

namespace _01_Remove_Negatives_And_Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			numbers.RemoveAll(item => item < 0);
			numbers.Reverse();
			if (numbers.Count == 0)
			{
				Console.WriteLine("empty");
			}
			else
			{
				Console.WriteLine(string.Join(" ", numbers));
			}
		}
	}
}
