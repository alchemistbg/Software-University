using System;
using System.Linq;

namespace _08_Condense_Array_To_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			int arraySum = 0;

			for (int i = 0; i < numArray.Length - 1; i++)
			{
				for (int k = 0; k < numArray.Length - 1; k++)
				{
					numArray[k] += numArray[k + 1];
				}
			}

			Console.WriteLine(numArray[0]);
		}
	}
}
