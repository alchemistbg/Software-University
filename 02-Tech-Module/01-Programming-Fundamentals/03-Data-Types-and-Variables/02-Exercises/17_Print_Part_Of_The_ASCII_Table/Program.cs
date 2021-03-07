using System;

namespace _17_Print_Part_Of_The_ASCII_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int start = int.Parse(Console.ReadLine());
			int stop = int.Parse(Console.ReadLine());

			for (int i = start; i <= stop; i++)
			{
				Console.Write((char)i);
				Console.Write(" ");
			}
			Console.WriteLine();
		}
	}
}
