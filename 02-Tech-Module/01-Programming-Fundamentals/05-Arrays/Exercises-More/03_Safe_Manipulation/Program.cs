using System;
using System.Linq;

namespace _03_Safe_Manipulation
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');

			string command = Console.ReadLine();
			while (command != "END")
			{
				if (command.Equals("Reverse"))
				{
					input = input.Reverse().ToArray();
				}
				else if (command.Equals("Distinct"))
				{
					input = input.Distinct().ToArray();
				}
				else if (command.StartsWith("Replace "))
				{
					string[] replaceCommand = command.Split(' ');
					int posToReplace = int.Parse(replaceCommand[1]);
					string textToReplace = replaceCommand[2];
					if (posToReplace >= 0 && posToReplace <= input.Length - 1)
					{
						input[posToReplace] = replaceCommand[2];
					}
					else
					{
						Console.WriteLine("Invalid input!");
					}
				}
				else
				{
					Console.WriteLine("Invalid input!");
				}
				command = Console.ReadLine();

			}
			Console.WriteLine(string.Join(", ", input));
		}
	}
}
