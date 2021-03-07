using System;

namespace _01_Hello_Name
{
	class Program
	{
		static void Main(string[] args)
		{
			printName(Console.ReadLine());
		}

		static void printName(string name)
		{
			Console.WriteLine($"Hello, {name}!");
		}
	}
}
