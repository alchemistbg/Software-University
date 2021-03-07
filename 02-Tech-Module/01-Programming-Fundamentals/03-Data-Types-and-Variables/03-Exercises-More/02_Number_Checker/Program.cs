using System;
using System.Numerics;

namespace _02_Number_Checker
{
	class Program
	{
		static void Main(string[] args)
		{
			string numToCheck = Console.ReadLine();
			try
			{
				BigInteger bi = BigInteger.Parse(numToCheck);
				Console.WriteLine("integer");
			}
			catch (Exception)
			{
				Console.WriteLine("floating-point");
			}
		}
	}
}
