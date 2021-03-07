using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Change_List
{
	class Program
	{
		static void Main(string[] args)
		{
			string numString = Console.ReadLine();
			List<int> list = numString.Split(' ').Select(int.Parse).ToList();

			string command = Console.ReadLine();

			while (command != "Even" && command != "Odd")
			{
				if (command.StartsWith("Delete"))
				{
					int whatToDelete = int.Parse(command.Split(' ').ToArray()[1]);
					list.RemoveAll(item => item == whatToDelete);
				}

				if (command.StartsWith("Insert"))
				{
					int whatToInsert = int.Parse(command.Split(' ').ToArray()[1]);
					int posToInsert = int.Parse(command.Split(' ').ToArray()[2]);
					list.Insert(posToInsert, whatToInsert);
				}

				command = Console.ReadLine();
			}

			for (int i = 0; i < list.Count; i++)
			{
				if (command.Equals("Even"))
				{
					if (list.ElementAt(i) % 2 == 0)
					{
						Console.Write(list.ElementAt(i) + " ");
					}
				}

				if (command.Equals("Odd"))
				{
					if (list.ElementAt(i) % 2 != 0)
					{
						Console.Write(list.ElementAt(i) + " ");
					}
				}
			}
			Console.WriteLine();
		}
	}
}
