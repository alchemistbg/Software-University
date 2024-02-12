using System;
using System.Collections.Generic;

namespace _05_FindAllPathsInALabyrinth
{
    class Program
    {
        private static List<char> solutions = new List<char>();

        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            char[,] labyrinth = new char[rows, cols];

            for (int r = 0; r < labyrinth.GetLength(0); r++)
            {
                //char[] line = Console.ReadLine().ToCharArray();
                string line = Console.ReadLine();
                for (int c = 0; c < labyrinth.GetLength(1); c++)
                {
                    //labyrinth[r, c] = line[c];
                    labyrinth[r, c] = line[c];
                }
            }

            FindAllPaths(labyrinth, 0, 0, solutions, '\0');
        }

        private static void FindAllPaths(char[,] labyrinth, int row, int col, List<char> solutions, char direction)
        {
            if (IsOutsideLabyrinth(labyrinth, row, col) || IsWall(labyrinth, row, col) || IsVisited(labyrinth, row, col))
            {
                return;
            }

            solutions.Add(direction);

            if (IsSolution(labyrinth, row, col))
            {
                Console.WriteLine(string.Join("", solutions));
                RemoveFromSolution(solutions);
                return;
            }

            labyrinth[row, col] = 'v';

            FindAllPaths(labyrinth, row - 1, col, solutions, 'U');
            FindAllPaths(labyrinth, row + 1, col, solutions, 'D');
            FindAllPaths(labyrinth, row, col - 1, solutions, 'L');
            FindAllPaths(labyrinth, row, col + 1, solutions, 'R');

            RemoveFromSolution(solutions);
            labyrinth[row, col] = '-';
        }

        private static bool IsSolution(char[,] labyrinth, int row, int col)
        {
            return labyrinth[row, col] == 'e';
        }

        private static bool IsVisited(char[,] labyrinth, int row, int col)
        {
            return labyrinth[row, col] == 'v';
        }

        private static bool IsOutsideLabyrinth(char[,] labyrinth, int row, int col)
        {
            return row < 0 ||
                   row >= labyrinth.GetLength(0) ||
                   col < 0 ||
                   col >= labyrinth.GetLength(1);
        }

        private static bool IsWall(char[,] labyrinth, int row, int col)
        {
            return labyrinth[row, col] == '*';
        }

        private static void RemoveFromSolution(List<char> solutions)
        {
            solutions.RemoveAt(solutions.Count - 1);
        }
    }
}
