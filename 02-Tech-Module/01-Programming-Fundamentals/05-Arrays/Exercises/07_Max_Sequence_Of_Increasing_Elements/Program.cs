using System;

namespace _07_Max_Sequence_Of_Increasing_Elements
{
	class Program
	{
		static void Main(string[] args)
		{
			string query = Console.ReadLine();
			int[] numArray = convertTextToNumArray(query);

			int start = 0;
			int len = 1;

			int bestStart = 0;
			int bestLen = 0;

			for (int i = 1; i < numArray.Length; i++)
			{
				if (numArray[i - 1] < numArray[i])
				{
					len++;
					if (bestLen < len && bestStart < i)
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
				Console.Write(numArray[i] + " ");
			}
		}

		static int[] convertTextToNumArray(string str)
		{
			string[] stringArray = str.Split(' ');
			int[] numArray = new int[stringArray.Length];
			for (int i = 0; i < stringArray.Length; i++)
			{
				numArray[i] = int.Parse(stringArray[i]);
			}
			return numArray;
		}
	}
}
