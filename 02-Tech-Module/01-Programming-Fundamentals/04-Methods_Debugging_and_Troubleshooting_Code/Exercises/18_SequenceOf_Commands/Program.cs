using System;
using System.Linq;

namespace _18_SequenceOf_Commands
{
	class Program
	{
		private const char ArgumentsDelimiter = ' ';

		public static void Main()
		{
			int sizeOfArray = int.Parse(Console.ReadLine());

			long[] array = Console.ReadLine()
				.Split(ArgumentsDelimiter)
				.Select(long.Parse)
				.ToArray();

			long[] editedArray = new long[sizeOfArray];

			string command = Console.ReadLine().Trim();

			while (!command.Equals("stop"))
			{

				int[] args = new int[2];

				if (command.Contains("add") ||
					command.Contains("subtract") ||
					command.Contains("multiply"))
				{
					string[] stringParams = command.Split(ArgumentsDelimiter);
					args[0] = int.Parse(stringParams[1]);
					args[1] = int.Parse(stringParams[2]);

					array = PerformAction(array, stringParams[0], args).Clone() as long[];
				}
				else
				{
					array = PerformAction(array, command, args).Clone() as long[];
				}

				PrintArray(array);
				Console.WriteLine();

				command = Console.ReadLine().Trim(); ;
			}
		}

		static long[] PerformAction(long[] arr, string action, int[] args)
		{
			long[] array = arr.Clone() as long[];
			int pos = args[0] - 1;
			int value = args[1];

			switch (action)
			{
				case "multiply":
					array[pos] *= value;
					break;
				case "add":
					array[pos] += value;
					break;
				case "subtract":
					array[pos] -= value;
					break;
				case "lshift":
					ArrayShiftLeft(array);
					break;
				case "rshift":
					ArrayShiftRight(array);
					break;
			}
			return array;
		}

		private static void ArrayShiftRight(long[] array)
		{
			long temp = array[array.Length - 1];
			for (int i = array.Length - 1; i >= 1; i--)
			{
				array[i] = array[i - 1];
			}
			array[0] = temp;
		}

		private static void ArrayShiftLeft(long[] array)
		{
			long temp = array[0];
			for (int i = 0; i < array.Length - 1; i++)
			{
				array[i] = array[i + 1];
			}
			array[array.Length - 1] = temp;
		}

		private static void PrintArray(long[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}
	}
}
