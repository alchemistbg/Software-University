using System;

namespace _02_Rotate_And_Sum
{
	class Program_v2
	{
		static void Main(string[] args)
		{
			string[] numberArrayAsText = Console.ReadLine().Split(' ');
			int[] arrayToRotate = new int[numberArrayAsText.Length];
			for (int i = 0; i < numberArrayAsText.Length; i++)
			{
				arrayToRotate[i] = int.Parse(numberArrayAsText[i]);
			}
			//int[] arrayToRotate = convertTextToNum(numberArrayAsText);
			int rotations = int.Parse(Console.ReadLine());
			rotateAndSumArray(arrayToRotate, rotations);
		}

		static void rotateAndSumArray(int[] arrayToRotate, int r)
		{
			int[] sum = new int[arrayToRotate.Length];
			for (int i = 0; i < r; i++)
			{
				int temp = arrayToRotate[arrayToRotate.Length - 1];
				for (int k = arrayToRotate.Length - 1; k >= 1; k--)
				{
					arrayToRotate[k] = arrayToRotate[k - 1];
				}
				arrayToRotate[0] = temp;

				for (int s = 0; s < sum.Length; s++)
				{
					sum[s] += arrayToRotate[s];
				}
				//string result = string.Join(" ", arrayToRotate);
			}
			//string sumString = string.Join(" ", sum);
			foreach (int number in sum)
			{
				Console.Write($"{number} ");
			}
			Console.WriteLine();
		}

		//static int[] convertTextToNum(string[] toConvert)
		//{
		//	int[] numArray = new int[toConvert.Length];
		//	for (int i = 0; i < numArray.Length; i++)
		//	{
		//		numArray[i] = int.Parse(toConvert[i]);
		//	}
		//	return numArray;
		//}
	}
}
