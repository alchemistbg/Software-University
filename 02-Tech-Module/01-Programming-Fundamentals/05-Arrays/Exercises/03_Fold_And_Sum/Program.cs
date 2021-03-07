using System;

namespace _03_Fold_And_Sum
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] arrayToFoldAstext = Console.ReadLine().Split(' ');
			int[] arrayToFold = new int[arrayToFoldAstext.Length];
			for (int i = 0; i < arrayToFold.Length; i++)
			{
				arrayToFold[i] = int.Parse(arrayToFoldAstext[i]);
			}
			foldArray(arrayToFold);
		}

		static void foldArray(int[] arrayToFold)
		{
			int foldSize = arrayToFold.Length / 4;
			int[] foldedArray = new int[foldSize * 2];

			int[] leftFold = new int[foldSize];
			for (int i = 0; i < foldSize; i++)
			{
				leftFold[i] = arrayToFold[i];
			}
			leftFold = leftFold.Reverse().ToArray();

			int[] rightFold = new int[foldSize];
			for (int i = 0; i < foldSize; i++)
			{
				rightFold[i] = arrayToFold[foldSize * 3 + i];
			}
			rightFold = rightFold.Reverse().ToArray();

			int[] centerFold = new int[2 * foldSize];
			for (int i = 0; i < foldSize * 2; i++)
			{
				centerFold[i] = arrayToFold[foldSize + i];
			}

			for (int i = 0; i < foldedArray.Length; i++)
			{
				if (i < foldSize)
				{
					foldedArray[i] = centerFold[i] + leftFold[i];
				}
				else
				{
					foldedArray[i] = centerFold[i] + rightFold[i - foldSize];
				}
			}

			foreach (int number in foldedArray)
			{
				Console.Write($"{number} ");
			}
			Console.WriteLine();
		}
	}
}
