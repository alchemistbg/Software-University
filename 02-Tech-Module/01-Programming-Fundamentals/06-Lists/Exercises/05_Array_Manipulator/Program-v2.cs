using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Array_Manipulator
{
	class Program_v2
	{
		static void Main(string[] args)
		{
			List<int> inputList = Console.ReadLine().
				Split(new char[] { ' ' }, StringSplitOptions.
				RemoveEmptyEntries).
				Select(int.Parse).
				ToList();

			string input = Console.ReadLine();

			while (input != "print")
			{
				string[] inputArr;

				if (input.Contains("add "))
				{
					inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					int index = int.Parse(inputArr[1]);
					int number = int.Parse(inputArr[2]);
					inputList.Insert(index, number);
				}

				if (input.Contains("addMany "))
				{
					inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					int index = int.Parse(inputArr[1]);
					List<int> listToAdd = new List<int>();
					for (int i = 2; i < inputArr.Length; i++)
					{
						listToAdd.Add(int.Parse(inputArr[i]));
					}
					inputList.InsertRange(index, listToAdd);
				}

				if (input.Contains("shift "))
				{
					inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					int shiftIndex = int.Parse(inputArr[1]) % inputList.Count;
					List<int> rotatedList = new List<int>();
					for (int i = shiftIndex; i < inputList.Count; i++)
					{
						rotatedList.Add(inputList[i]);
					}
					for (int i = 0; i < shiftIndex; i++)
					{
						rotatedList.Add(inputList[i]);
					}
					inputList = rotatedList;
				}

				if (input.Contains("remove "))
				{
					inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					int index = int.Parse(inputArr[1]);
					inputList.RemoveAt(index);
				}

				if (input.Equals("sumPairs"))
				{
					List<int> summedList = new List<int>();
					if (inputList.Count % 2 == 0)
					{
						for (int i = 0; i < inputList.Count; i += 2)
						{
							summedList.Add(inputList[i] + inputList[i + 1]);
						}
					}
					else
					{
						for (int i = 0; i < inputList.Count - 1; i += 2)
						{
							summedList.Add(inputList[i] + inputList[i + 1]);
						}
						summedList.Add(inputList.Last());
					}
					inputList = summedList;
				}

				if (input.Contains("contains "))
				{
					inputArr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
					int number = int.Parse(inputArr[1]);
					if (inputList.Contains(number))
					{
						Console.WriteLine(inputList.IndexOf(number));
					}
					else
					{
						Console.WriteLine("-1");
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine($"[{string.Join(", ", inputList)}]");
		}
	}
}
