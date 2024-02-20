using System;
using System.Collections.Generic;

namespace _02_AreasInMatrix
{
    public class Node
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }

    class Program
    {
        static char[,] matrix;
        static bool[,] visited;
        
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            matrix = ReadMatrixInput(rows, cols);
            visited = new bool[rows, cols];

            int areasCount = 0;
            SortedDictionary<char, int> areasData = new SortedDictionary<char, int>();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (visited[r, c])
                    {
                        continue;
                    }

                    DFS(r, c);

                    char symbol = matrix[r, c];
                    if (!areasData.ContainsKey(symbol))
                    {
                        areasData.Add(symbol, 0);
                    }

                    areasData[symbol] += 1;
                    areasCount += 1;
                }
            }

            //PrintMatrix();
            PrintResult(areasCount, areasData);
        }

        private static void DFS(int row, int col)
        {
            visited[row, col] = true;
            List<Node> children = GetChildren(row, col);

            foreach (Node child in children)
            {
                DFS(child.Row, child.Col);
            }
        }

        private static List<Node> GetChildren(int row, int col)
        {
            List<Node> children = new List<Node>();

            if (IsInsideMatrix(row - 1, col) &&
                !IsNodeVisited(row - 1, col) &&
                IsChildNode(row, col, row - 1, col))
            {
                children.Add(new Node { Row = row - 1, Col = col });
            }

            if (IsInsideMatrix(row + 1, col) &&
                !IsNodeVisited(row + 1, col) &&
                IsChildNode(row, col, row + 1, col))
            {
                children.Add(new Node { Row = row + 1, Col = col });
            }

            if (IsInsideMatrix(row, col - 1) &&
                !IsNodeVisited(row, col - 1) &&
                IsChildNode(row, col, row, col - 1))
            {
                children.Add(new Node { Row = row, Col = col - 1 });
            }

            if (IsInsideMatrix(row, col + 1) &&
                !IsNodeVisited(row, col + 1) &&
                IsChildNode(row, col, row, col + 1))
            {
                children.Add(new Node { Row = row, Col = col + 1 });
            }
            ;
            return children;
        }

        private static bool IsInsideMatrix(int row, int col)
        {
            return row >= 0 &&
                   row < matrix.GetLength(0) &&
                   col >= 0 &&
                   col < matrix.GetLength(1);
        }

        private static bool IsNodeVisited(int row, int col)
        {
            return visited[row, col];
        }

        private static bool IsChildNode(int parentRow, int parentCol, int childRow, int childCol)
        {
            return matrix[parentRow, parentCol] == matrix[childRow, childCol];
        }

        private static char[,] ReadMatrixInput(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string matrixRow = Console.ReadLine();
                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = matrixRow[c];
                }
            }

            return matrix;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }

                Console.WriteLine();
            }
        }
        private static void PrintResult(int totalAreas, SortedDictionary<char, int> areasData)
        {
            Console.WriteLine($"Areas: {totalAreas}");
            foreach (var kvp in areasData)
            {
                Console.WriteLine($"Letter '{kvp.Key}' -> {kvp.Value}");
            }
        }
    }
}
