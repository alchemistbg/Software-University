using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Pokemon_Don_t_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> mainList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			List<int> removedItems = new List<int>();

			while (mainList.Count > 0)
			{
				int index = int.Parse(Console.ReadLine());
				int remItem = 0;

				if (index < 0)
				{
					remItem = mainList[0];
					mainList[0] = mainList[mainList.Count - 1];
				}
				else if (index > mainList.Count - 1)
				{
					remItem = mainList[mainList.Count - 1];
					mainList[mainList.Count - 1] = mainList[0];
				}
				else
				{
					remItem = mainList[index];
					mainList.RemoveAt(index);
				}
				removedItems.Add(remItem);

				for (int i = 0; i < mainList.Count; i++)
				{
					if (mainList[i] <= remItem)
					{
						mainList[i] += remItem;
					}
					else
					{
						mainList[i] -= remItem;
					}
				}
			}
			Console.WriteLine(removedItems.Sum());
		}
	}
}
