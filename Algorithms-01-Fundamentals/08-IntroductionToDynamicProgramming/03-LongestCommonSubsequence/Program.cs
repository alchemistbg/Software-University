using System;
using System.Collections.Generic;

namespace _03_LongestCommonSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int[,] table = new int[str1.Length + 1, str2.Length + 1];

            for (int r = 1; r < table.GetLength(0); r++)
            {
                for (int c = 1; c < table.GetLength(1); c++)
                {
                    if (str1[r - 1] == str2[c - 1])
                    {
                        table[r, c] = table[r - 1, c - 1] + 1;
                    }
                    else
                    {
                        table[r, c] = Math.Max(table[r - 1, c], table[r, c - 1]);
                    }
                }
            }

            Console.WriteLine($"The longest common sequence has {table[str1.Length, str2.Length]} elements. They are:");
            int rows = str1.Length;
            int cols = str2.Length;

            Stack<char> lcs = new Stack<char>();
            while (rows > 0 && cols > 0)
            {
                if (str1[rows - 1] == str2[cols - 1])
                {
                    lcs.Push(str1[rows - 1]);
                    rows -= 1;
                    cols -= 1;
                }
                else if (table[rows - 1, cols] > table[rows, cols - 1])
                {
                    rows -= 1;
                }
                else
                {
                    cols -= 1;
                }
            }

            Console.WriteLine($"[{string.Join(", ", lcs)}]");
        }
    }
}
