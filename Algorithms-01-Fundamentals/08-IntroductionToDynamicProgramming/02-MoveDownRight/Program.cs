using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_MoveDownRight
{
    //NEED TO IMPROVE THE CODE
    class Program
    {
        static int[,] matrix;
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            matrix = ParseInput(rows, cols);

            //PrintMatrix(matrix);

            Solve();

        }

        private static void Solve()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] optimalPath = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (r > 0 && c > 0)
                    {
                        optimalPath[r, c] = Math.Max(optimalPath[r - 1, c], optimalPath[r, c - 1]) + matrix[r, c];
                    }
                    else if (r > 0 && c == 0)
                    {
                        optimalPath[r, c] = optimalPath[r - 1, c] + matrix[r, c];
                    }
                    else if (r == 0 && c > 0)
                    {
                        optimalPath[r, c] = optimalPath[r, c - 1] + matrix[r, c];
                    }
                    else
                    {
                        optimalPath[r, c] = matrix[r, c];
                    }
                }
            }

            //PrintMatrix(optimalPath);

            ExtractOptimalPath(optimalPath);
            //return optimalPath[rows - 1,cols - 1];
        }

        private static void PrintMatrix(int[,] matrixToPrint)
        {
            for (int r = 0; r < matrixToPrint.GetLength(0); r++)
            {
                for (int c = 0; c < matrixToPrint.GetLength(1); c++)
                {
                    Console.Write($"{matrixToPrint[r, c]} ");
                }
                Console.WriteLine();
            }
        }

        private static void ExtractOptimalPath(int[,] matrixToExtract)
        {
            int rows = matrixToExtract.GetLength(0) - 1;
            int cols = matrixToExtract.GetLength(1) - 1;
            
            Stack<string> path = new Stack<string>();

            path.Push($"[{rows}, {cols}]");

            while (rows > 0 && cols > 0)
            {
                int upperCell = matrixToExtract[rows - 1, cols];
                int leftCell = matrixToExtract[rows, cols - 1];
                
                if (leftCell >= upperCell)
                {
                    cols -= 1;
                }
                else
                {
                    rows -= 1;
                }

                path.Push($"[{rows}, {cols}]");
            }

            while (rows > 0)
            {
                rows -= 1;
                path.Push($"[{rows}, {cols}]");
            }

            while (cols > 0)
            {
                cols -= 1;
                path.Push($"[{rows}, {cols}]");
            }

            //path.Push($"[{0}, {0}]");
            Console.WriteLine(string.Join(" ", path));
        }

        private static int[,] ParseInput(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            for (int r = 0; r < result.GetLength(0); r++)
            {
                int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int c = 0; c < cols; c++)
                {
                    result[r, c] = line[c];
                }
            }
            return result;
        }
    }
}
