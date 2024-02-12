using System;
using System.Collections.Generic;

namespace _06_QueensPuzzle
{
    class Program
    {
        public static HashSet<int> attackedRow = new HashSet<int>();
        public static HashSet<int> attackedCol = new HashSet<int>();
        public static HashSet<int> attackedLeftDiagonal = new HashSet<int>();
        public static HashSet<int> attackedRightDiagonal = new HashSet<int>();
        static void Main(string[] args)
        {
            bool[,] chessBoard = new bool[8,8];

            PlaceQueens(chessBoard, 0);
        }

        private static void PlaceQueens(bool[,] chessBoard, int row)
        {
            if (row == chessBoard.GetLength(0))
            {
                PrintBoard(chessBoard);
                return;
            }

            for (int col = 0; col < chessBoard.GetLength(1); col++)
            {
                if (!IsAttackedCell(row, col))
                {
                    chessBoard[row, col] = true;
                    attackedRow.Add(row);
                    attackedCol.Add(col);
                    attackedLeftDiagonal.Add(row - col);
                    attackedRightDiagonal.Add(row + col);
                    
                    PlaceQueens(chessBoard, row + 1);

                    chessBoard[row, col] = false;
                    attackedRow.Remove(row);
                    attackedCol.Remove(col);
                    attackedLeftDiagonal.Remove(row - col);
                    attackedRightDiagonal.Remove(row + col);
                }
            }
        }

        private static bool IsAttackedCell(int row, int col)
        {
            return attackedRow.Contains(row) ||
                   attackedCol.Contains(col) ||
                   attackedLeftDiagonal.Contains(row - col) ||
                   attackedRightDiagonal.Contains(row + col);
        }

        private static void PrintBoard(bool[,] chessBoard)
        {
            for (int r = 0; r < chessBoard.GetLength(0); r++)
            {
                for (int c = 0; c < chessBoard.GetLength(1); c++)
                {
                    if (chessBoard[r, c] == true)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
