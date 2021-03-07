using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Array_Manipulator
{
	class Program_v1
	{
		//needs to be rewriten - 58/100

		//static void Main(string[] args)
		//{
		//	List<int> startList = Console.ReadLine().
		//		Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
		//		Select(int.Parse).
		//		ToList();
		//	string[] command = Console.ReadLine().
		//		Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
		//		ToArray();
		//	while (command[0] != "print")
		//	{
		//		if (command[0] == "add")
		//		{
		//			int queryIndex = int.Parse(command[1]);
		//			int newElement = int.Parse(command[2]);
		//			startList.Insert(queryIndex, newElement);
		//		}

		//		if (command[0] == "addMany")
		//		{
		//			int queryIndex = int.Parse(command[1]);
		//			int[] numToInsert = new int[command.Length - 2];
		//			for (int i = 0; i < command.Length - 2; i++)
		//			{
		//				numToInsert[i] = int.Parse(command[i + 2]);
		//			}
		//			startList.InsertRange(queryIndex, numToInsert);
		//		}

		//		if (command[0] == ("contains"))
		//		{
		//			int queryIndex = int.Parse(command[1]);
		//			int answer = getElementIndex(startList, queryIndex);
		//			Console.WriteLine(answer);
		//		}

		//		if (command[0] == "remove")
		//		{
		//			int queryIndex = int.Parse(command[1]);
		//			startList.RemoveAt(queryIndex);
		//		}

		//		if (command[0] == "shift")
		//		{
		//			int indexShift = int.Parse(command[1]);
		//			if (indexShift > startList.Count)
		//			{
		//				indexShift %= startList.Count;
		//			}
		//			int[] movedLeft = startList.GetRange(indexShift, startList.Count - indexShift).ToArray();
		//			int[] rotated = startList.GetRange(0, indexShift).ToArray();
		//			startList.RemoveAll(item => item > int.MinValue);
		//			startList.AddRange(movedLeft);
		//			startList.AddRange(rotated);
		//		}

		//		if (command[0] == "sumPairs")
		//		{
		//			int iterator = 0;
		//			if (startList.Count % 2 == 0)
		//			{
		//				iterator = startList.Count;
		//			}
		//			else
		//			{
		//				iterator = startList.Count - 1;
		//			}

		//			List<int> summedList = new List<int>();
		//			for (int i = 1; i < iterator; i += 2)
		//			{
		//				summedList.Add(startList.ElementAt(i - 1) + startList.ElementAt(i));
		//			}
		//			startList = new List<int>(summedList);
		//		}
		//		command = Console.ReadLine().
		//			Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
		//			ToArray();
		//	}
		//	string finalList = string.Join(", ", startList);
		//	Console.WriteLine($"[{finalList}]");
		//}

		//static int getElementIndex(List<int> queryList, int queryNum)
		//{
		//	int result = 0;
		//	if (queryList.Contains(queryNum))
		//	{
		//		result = queryList.FindIndex(0, item => item == queryNum);
		//	}
		//	else
		//	{
		//		result = -1;
		//	}
		//	return result;
		//}
	}
}
