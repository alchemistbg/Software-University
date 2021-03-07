using System;
using System.Collections.Generic;

namespace _07_Primes_In_Given_Range
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			List<int> list = getPrimesList(num1, num2);
			printList(list);
		}

		static List<int> getPrimesList(int n1, int n2)
		{
			List<int> primes = new List<int>();
			for (int i = n1; i <= n2; i++)
			{
				if (isPrime(i))
				{
					primes.Add(i);
				}
			}
			return primes;
		}

		static Boolean isPrime(int number)
		{
			if (number < 2)
			{
				return false;
			}
			if (number > 1)
			{
				for (int i = 2; i <= Math.Sqrt(number); i++)
				{
					if (number % i == 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		static void printList(List<int> listToPrint)
		{
			if (listToPrint.Count == 0)
			{
				Console.WriteLine("(empty list)");
			}
			else
			{
				Console.Write(listToPrint[0]);
				for (int i = 1; i < listToPrint.Count; i++)
				{
					Console.Write(", " + listToPrint[i]);
				}
				Console.WriteLine();
			}
		}
	}
}
