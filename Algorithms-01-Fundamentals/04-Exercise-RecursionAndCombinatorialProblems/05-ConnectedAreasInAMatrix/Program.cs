using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ConnectedAreasInAMatrix
{

    public class Area
    {
        public int Size { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] matrix = ReadMatrix(rows, cols);
            bool[,] visited = new bool[rows, cols];

            List<Area> areasList = new List<Area>();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == '*')
                    {
                        continue;
                    }

                    if (visited[r, c])
                    {
                        continue;
                    }

                    //visited[r, c] = true;

                    int areaSize = GetAreaSize(matrix, r, c, visited);

                    Area area = new Area { Row = r, Col = c, Size = areaSize};
                    areasList.Add(area);
                }
            }

            List<Area> sortedAreas = areasList.OrderByDescending(a => a.Size)
                .ThenBy(a => a.Row)
                .ThenBy(a => a.Col)
                .ToList();

            Console.WriteLine($"Total areas found: {sortedAreas.Count}");
            for (int i = 0; i < sortedAreas.Count; i++)
            {
                Console.WriteLine($"Area #{i + 1} at ({sortedAreas[i].Row}, {sortedAreas[i].Col}), size: {sortedAreas[i].Size}");
            }

            //Print(matrix);
        }

        private static int GetAreaSize(char[,] matrix, int row, int col, bool[,] visited)
        {
            if (IsOutside(matrix, row, col))
            {
                return 0;
            }

            if (visited[row, col])
            {
                return 0;
            }

            if (matrix[row, col] == '*')
            {
                return 0;
            }

            //if (matrix[row, col] == '-')
            //{
            //    return 1;
            //}

            visited[row, col] = true;
            
            return 1 + GetAreaSize(matrix, row + 1, col, visited) +
                GetAreaSize(matrix, row - 1, col, visited) +
                GetAreaSize(matrix, row, col + 1, visited) +
                GetAreaSize(matrix, row, col - 1, visited);

        }

        private static bool IsOutside(char[,] matrix, int row, int col)
        {
            return row < 0 ||
                   row >= matrix.GetLength(0) ||
                   col < 0 ||
                   col >= matrix.GetLength(1);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                Console.WriteLine(line);
                for (int c = 0; c < line.Length; c++)
                {
                    matrix[r, c] = line[c];
                }
            }

            return matrix;
        }

        //private static void Print(char[,] matrix)
        //{
        //    Console.WriteLine(new string('+', 20));

        //    for (int r = 0; r < matrix.GetLength(0); r++)
        //    {
        //        for (int c = 0; c < matrix.GetLength(1); c++)
        //        {
        //            Console.Write(matrix[r, c]);
        //        }

        //        Console.WriteLine();
        //    }
        //}
    }
}
