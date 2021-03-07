using System;

namespace _08_Most_Frequent_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string query = Console.ReadLine();
			string[] queryAsText = query.Split(' ');
			int[] queryAsNumbers = new int[queryAsText.Length];
			for (int i = 0; i < queryAsNumbers.Length; i++)
			{
				queryAsNumbers[i] = int.Parse(queryAsText[i]);
			}

			int[] counters = new int[queryAsNumbers.Length];

			for (int i = 0; i < queryAsNumbers.Length; i++)
			{
				for (int k = 0; k < queryAsNumbers.Length; k++)
				{
					if (queryAsNumbers[i] == queryAsNumbers[k])
					{
						counters[i]++;
					}
				}
			}
			int maxElementIndex = getMaxElementIndex(counters);
			Console.WriteLine(queryAsNumbers[maxElementIndex]);
		}

		static int getMaxElementIndex(int[] numArray)
		{
			int max = int.MinValue;

			for (int i = 0; i < numArray.Length; i++)
			{
				if (numArray[i] > max)
				{
					max = numArray[i];
				}
			}

			int maxIndex = 0;
			for (int i = 0; i < numArray.Length; i++)
			{
				if (numArray[i] == max)
				{
					maxIndex = i;
					break;
				}
			}
			return maxIndex;
		}
	}
}
