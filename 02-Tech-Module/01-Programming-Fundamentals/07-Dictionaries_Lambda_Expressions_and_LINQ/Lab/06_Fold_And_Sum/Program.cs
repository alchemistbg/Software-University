using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Fold_And_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int halfLength = input.Length / 2;
			int fourtLength = input.Length / 4;

			int[] outerArray = new int[halfLength];
			int[] innerArray = new int[halfLength];

			for (int i = fourtLength; i < input.Length - fourtLength; i++)
			{
				innerArray[i - fourtLength] = input[i];
			}

			var leftPart = input.Take(fourtLength);
			int counterLeft = 0;
			foreach (var item in leftPart.Reverse())
			{
				outerArray[counterLeft] = item;
				counterLeft++;
			}

			var rightPart = input.TakeLast(fourtLength).Reverse();
			int counterRight = fourtLength;
			foreach (var item in rightPart)
			{
				outerArray[counterRight] = item;
				counterRight++;
			}

			List<int> result = new List<int>();

			for (int i = 0; i < outerArray.Length; i++)
			{
				result.Add(outerArray[i] + innerArray[i]);
			}

			Console.WriteLine(string.Join(' ', result));
		}
	}
}
