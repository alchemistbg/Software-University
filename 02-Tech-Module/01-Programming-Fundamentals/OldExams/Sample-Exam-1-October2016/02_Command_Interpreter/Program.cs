using System;
using System.Linq;

namespace _02_Command_Interpreter
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] array = Console.ReadLine().Split(" \t\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

			string command = Console.ReadLine();
			while (command != "end")
			{
				string[] commandArr = command.Split(' ');
				switch (commandArr[0])
				{
					case "reverse":
						int startReverse = int.Parse(commandArr[2]);
						int countReverse = int.Parse(commandArr[4]);
						array = Reverse(array, startReverse, countReverse);
						break;
					case "sort":
						int startSort = int.Parse(commandArr[2]);
						int countSort = int.Parse(commandArr[4]);
						array = Sort(array, startSort, countSort);
						break;
					case "rollLeft":
						long rollLeftCount = long.Parse(commandArr[1]);
						array = RollLeft(array, rollLeftCount);
						break;
					case "rollRight":
						long rollRightCount = long.Parse(commandArr[1]);
						array = RollRight(array, rollRightCount);
						break;
					default:
						break;
				}
				command = Console.ReadLine();
			}

			Console.WriteLine($"[{string.Join(", ", array)}]");
		}

		private static string[] RollRight(string[] array, long rollRightCount)
		{
			if (rollRightCount < 0)
			{
				Console.WriteLine("Invalid input parameters.");
			}
			else
			{
				rollRightCount = rollRightCount % array.Length;
				for (int j = 0; j < rollRightCount; j++)
				{
					string temp = array[array.Length - 1];
					for (int i = array.Length - 1; i > 0; i--)
					{
						array[i] = array[i - 1];
					}
					array[0] = temp;
				}
			}
			return array;
		}

		private static string[] RollLeft(string[] array, long rollLeftCount)
		{
			if (rollLeftCount < 0)
			{
				Console.WriteLine("Invalid input parameters.");
			}
			else
			{
				rollLeftCount = rollLeftCount % array.Length;
				for (int j = 0; j < rollLeftCount; j++)
				{
					string temp = array[0];
					for (int i = 0; i < array.Length - 1; i++)
					{
						array[i] = array[i + 1];
					}
					array[array.Length - 1] = temp;
				}
			}
			return array;
		}

		static string[] Sort(string[] array, int startSort, int countSort)
		{
			if (startSort < 0 || startSort > array.Length - 1 || countSort < 0 || countSort > array.Length || startSort + countSort > array.Length)
			{
				Console.WriteLine("Invalid input parameters.");
			}
			else
			{
				string[] temp = new string[countSort];
				for (int i = 0; i < temp.Length; i++)
				{
					temp[i] = array[i + startSort];
				}
				temp = temp.OrderBy(x => x).ToArray();
				for (int i = startSort; i < startSort + countSort; i++)
				{
					array[i] = temp[i - startSort];
				}
			}
			return array;
		}

		static string[] Reverse(string[] array, int startReverse, int countReverse)
		{
			if (startReverse < 0 || startReverse > array.Length - 1 || countReverse < 0 || countReverse > array.Length || startReverse + countReverse > array.Length)
			{
				Console.WriteLine("Invalid input parameters.");
			}
			else
			{
				string[] temp = new string[countReverse];
				for (int i = 0; i < temp.Length; i++)
				{
					temp[i] = array[i + startReverse];
				}
				temp = temp.Reverse().ToArray();

				for (int i = startReverse; i < startReverse + countReverse; i++)
				{
					array[i] = temp[i - startReverse];
				}
			}
			return array;
		}
	}
}
