using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Count_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine()
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			Dictionary<int, int> listInfo = new Dictionary<int, int>();

			for (int i = 0; i < input.Count; i++)
			{
				if (listInfo.ContainsKey(input[i]))
				{
					listInfo[input[i]]++;
				}
				else
				{
					listInfo.Add(input[i], 1);
				}
			}

			List<int> dictKeys = listInfo.Keys.ToList();
			dictKeys.Sort();

			for (int i = 0; i < dictKeys.Count; i++)
			{
				Console.WriteLine($"{dictKeys[i]} -> {listInfo[dictKeys[i]]}");
			}


		}
	}
}
