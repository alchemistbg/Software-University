using System;
using System.Linq;

namespace _04_Grab_And_Go
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int num = int.Parse(Console.ReadLine());

			int numLastPos = -1;
			for (int i = 0; i < numArray.Length; i++)
			{
				if (numArray[i] == num)
				{
					numLastPos = i;
				}
			}

			long sumToPrint = 0l;
			if (numLastPos < 0)
			{
				Console.WriteLine("No occurrences were found!");
			}
			else
			{
				for (int i = 0; i < numLastPos; i++)
				{
					sumToPrint += numArray[i];
				}
				Console.WriteLine(sumToPrint);
			}
		}
	}
}
