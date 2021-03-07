using System;

namespace _04_Variable_In_Hexadecimal_Format
{
	class Program
	{
		static void Main(string[] args)
		{
			int input = Convert.ToInt32(Console.ReadLine(), 16);

			Console.WriteLine(input);
		}
	}
}
