using System;
using System.Linq;

namespace _02_Rotate_And_Sum
{
	class Program_v1
	{
		//static void Main(string[] args)
		//{
		//	int[] arrayToRotate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
		//	int rotations = int.Parse(Console.ReadLine());
		//	rotateAndSumArray(arrayToRotate, rotations);
		//}

		//static void rotateAndSumArray(int[] arrayToRotate, int r)
		//{
		//	int[] sum = new int[arrayToRotate.Length];
		//	for (int i = 0; i < r; i++)
		//	{
		//		int temp = arrayToRotate[arrayToRotate.Length - 1];
		//		for (int k = arrayToRotate.Length - 1; k >= 1; k--)
		//		{
		//			arrayToRotate[k] = arrayToRotate[k - 1];
		//		}
		//		arrayToRotate[0] = temp;

		//		for (int s = 0; s < sum.Length; s++)
		//		{
		//			sum[s] += arrayToRotate[s];
		//		}
		//		string result = string.Join(' ', arrayToRotate);
		//	}
		//	string sumString = string.Join(' ', sum);
		//	Console.WriteLine(sumString);
		//}
	}
}
