﻿using System;

namespace _01_Passed
{
	class Program
	{
		static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());

			if (grade >= 3)
			{
				Console.WriteLine("Passed!");
			}
		}
	}
}
