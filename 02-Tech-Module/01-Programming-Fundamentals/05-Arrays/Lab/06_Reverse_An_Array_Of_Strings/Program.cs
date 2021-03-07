using System;
using System.Linq;

namespace _06_Reverse_An_Array_Of_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');

			/*for (int i = 0; i < input.Length / 2; i++)
			{
				int arrLength = input.Length - 1;

				string current = input[i];
				input[i] = input[arrLength - i];
				input[arrLength - i] = current;
			}
			Console.WriteLine(string.Join(' ', input));*/

			Console.WriteLine(string.Join(' ', input.Reverse()));
		}
	}
}
