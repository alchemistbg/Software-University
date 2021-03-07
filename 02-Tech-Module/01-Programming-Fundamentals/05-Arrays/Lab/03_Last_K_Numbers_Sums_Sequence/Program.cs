using System;

namespace _03_Last_K_Numbers_Sums_Sequence
{
	class Program
	{
		static void Main(string[] args)
		{
			int arraySize = int.Parse(Console.ReadLine());
			int sumSpan = int.Parse(Console.ReadLine());

			long[] numArray = new long[arraySize];
			numArray[0] = 1;

			for (int i = 0; i < numArray.Length; i++)
			{
				if (sumSpan >= i)
				{
					for (int k = 0; k < i; k++)
					{
						numArray[i] += numArray[k];
					}
				}
				else
				{
					for (int k = i - sumSpan; k < i; k++)
					{
						numArray[i] += numArray[k];
					}
				}
			}

			Console.WriteLine(string.Join(' ', numArray));
		}
	}
}
