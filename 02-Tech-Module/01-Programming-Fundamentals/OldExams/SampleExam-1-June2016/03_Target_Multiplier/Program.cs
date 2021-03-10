using System;
using System.Linq;

namespace _03_Target_Multiplier
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int rows = input[0];
			int cols = input[1];

			long[,] matrix = new long[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				long[] rowToInsert = Console.ReadLine().Split().Select(long.Parse).ToArray();
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = rowToInsert[j];
				}
			}

			int[] cell = Console.ReadLine().Split().Select(int.Parse).ToArray();
			int row = cell[0];
			int col = cell[1];

			long sum = 0;
			for (int i = row - 1; i <= row + 1; i++)
			{
				for (int j = col - 1; j <= col + 1; j++)
				{
					sum += matrix[i, j];
				}
			}
			sum -= matrix[row, col];
			long oldCell = matrix[row, col];
			matrix[row, col] *= sum;

			for (int i = row - 1; i <= row + 1; i++)
			{
				for (int j = col - 1; j <= col + 1; j++)
				{
					matrix[i, j] *= oldCell;
				}
			}
			matrix[row, col] /= oldCell;


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (j != matrix.GetLength(1) - 1)
					{
						Console.Write(matrix[i, j] + " ");
					}
					else
					{
						Console.Write(matrix[i, j]);
					}
				}
				Console.WriteLine();
			}
		}
	}
}
