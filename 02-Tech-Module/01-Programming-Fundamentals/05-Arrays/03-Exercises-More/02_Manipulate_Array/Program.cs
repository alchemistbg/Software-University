using System;
using System.Linq;

namespace _02_Manipulate_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(' ');

			int num = int.Parse(Console.ReadLine());
			for (int i = 0; i < num; i++)
			{
				string command = Console.ReadLine();
				if (command.Equals("Reverse"))
				{
					input = input.Reverse().ToArray();
				}
				else if (command.Equals("Distinct"))
				{
					input = input.Distinct().ToArray();
				}
				else
				{
					string[] replaceCommand = command.Split(' ');
					int posToReplace = int.Parse(replaceCommand[1]);
					input[posToReplace] = replaceCommand[2];
				}
			}
			Console.WriteLine(string.Join(", ", input));
		}
	}
}
