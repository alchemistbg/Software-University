using System;
using System.Linq;
using System.Text;

namespace _04_Triple_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			long[] numArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

			StringBuilder result = new StringBuilder();

			for (int i = 0; i < numArray.Length; i++)
			{
				for (int j = i + 1; j < numArray.Length; j++)
				{
					for (int k = 0; k < numArray.Length; k++)
					{
						long sum = numArray[i] + numArray[j];
						if (sum == numArray[k])
						{
							result.Append($"{numArray[i]} + {numArray[j]} == {numArray[k]}\r\n");
							break;
						}
					}
				}
			}

			if (result.Length == 0)
			{
				Console.WriteLine("No");
			}
			else
			{
				Console.Write(result.ToString());
			}
		}
	}
}
