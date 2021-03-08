using System;
using System.Collections.Generic;

namespace _02_Randomize_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] strArray = Console.ReadLine().Split(' ');

			string[] rndArray = new string[strArray.Length];

			UniqueRandomGenerator urg = new UniqueRandomGenerator(0, strArray.Length);
			int[] rndIndex = urg.getUniqueNumbers();

			for (int i = 0; i < rndArray.Length; i++)
			{
				rndArray[i] = strArray[rndIndex[i]];
			}

			foreach (string word in rndArray)
			{
				Console.WriteLine(word);
			}
		}
	}

	class UniqueRandomGenerator
	{
		int min = 0;
		int max = 0;
		public UniqueRandomGenerator(int mi, int ma)
		{
			min = mi;
			max = ma;
		}

		public int[] getUniqueNumbers()
		{
			List<int> uniqueNumbers = new List<int>();

			Random rnd = new Random();
			for (; ; )
			{
				if (uniqueNumbers.Count == max)
				{
					break;
				}
				else
				{
					int rndNum = rnd.Next(min, max);
					if (!uniqueNumbers.Contains(rndNum))
					{
						uniqueNumbers.Add(rndNum);
					}
				}
			}

			//printUniqueNumbers(uniqueNumbers);
			return uniqueNumbers.ToArray();
		}

		public void printUniqueNumbers(List<int> uniqueNumbers)
		{
			foreach (int item in uniqueNumbers)
			{
				Console.WriteLine(item);
			}
		}
	}
}
