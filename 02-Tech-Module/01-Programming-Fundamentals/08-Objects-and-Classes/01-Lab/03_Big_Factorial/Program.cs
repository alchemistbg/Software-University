﻿using System;
using System.Numerics;

namespace _03_Big_Factorial
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			BigInteger fact = 1;
			for (int i = 2; i <= num; i++)
			{
				fact *= i;
			}
			Console.WriteLine(fact);
		}
	}
}
