using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Array_Modifier
{
	class Program
	{
		static void Main(string[] args)
		{
			List<long> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

			string command = Console.ReadLine();
			while (command != "end")
			{
				if (command.StartsWith("swap"))
				{
					string[] inputArr = command.Split(' ');
					int i1 = int.Parse(inputArr[1]);
					int i2 = int.Parse(inputArr[2]);
					long temp = input[i1];
					input[i1] = input[i2];
					input[i2] = temp;
				}
				else if (command.StartsWith("multiply"))
				{
					string[] inputArr = command.Split(' ');
					int i1 = int.Parse(inputArr[1]);
					int i2 = int.Parse(inputArr[2]);
					input[i1] = input[i1] * input[i2];
				}
				else if (command == "decrease")
				{
					for (int i = 0; i < input.Count; i++)
					{
						input[i] -= 1;
					}
				}
				command = Console.ReadLine();
			}

			Console.WriteLine(string.Join(", ", input));
		}
	}
}
