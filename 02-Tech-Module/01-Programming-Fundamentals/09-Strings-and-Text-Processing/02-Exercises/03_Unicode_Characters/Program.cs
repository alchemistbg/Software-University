using System;

namespace _03_Unicode_Characters
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			foreach (char ch in input)
			{
				Console.Write($"\\u{(int)ch:x4}");
			}
			Console.WriteLine();
		}
	}
}
