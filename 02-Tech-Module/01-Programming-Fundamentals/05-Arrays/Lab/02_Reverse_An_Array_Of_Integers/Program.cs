using System;

namespace _02_Reverse_An_Array_Of_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			int arraySize = int.Parse(Console.ReadLine());
			int[] array = new int[arraySize];
			while (arraySize > 0)
			{
				array[(array.Length - 1) - (arraySize - 1)] = int.Parse(Console.ReadLine());
				arraySize--;
			}
			for (int i = array.Length - 1; i >= 0; i--)
			{
				Console.Write($"{array[i]} ");
			}
			Console.WriteLine();
		}
	}
}
