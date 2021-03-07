using System;

namespace _01_Debit_Card_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());
			int num4 = int.Parse(Console.ReadLine());

			string output = $"{num1:D4} {num2:D4} {num3:D4} {num4:D4}";
			Console.WriteLine(output);
		}
	}
}
