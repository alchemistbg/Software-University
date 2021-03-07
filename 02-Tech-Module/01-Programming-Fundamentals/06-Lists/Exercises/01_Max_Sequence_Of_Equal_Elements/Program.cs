using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Max_Sequence_Of_Equal_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string numString = Console.ReadLine();
			List<int> list = numString.Split(' ').Select(int.Parse).ToList();

			int start = 0;
			int len = 1;

			int bestStart = 0;
			int bestLen = 1;

			for (int i = 1; i < list.Count; i++)
			{
				if (list.ElementAt(i - 1) == list.ElementAt(i))
				{
					len++;
					if (bestLen < len)
					{
						bestStart = start;
						bestLen = len;
					}
				}
				else
				{
					start = i;
					len = 1;
				}
			}

			for (int i = bestStart; i < bestStart + bestLen; i++)
			{
				Console.Write(list.ElementAt(i) + " ");
			}
			Console.WriteLine();
		}
	}
}
