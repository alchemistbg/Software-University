using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] table = new int[numbers1.Length + 1, numbers2.Length + 1];

            for (int r = 1; r < table.GetLength(0); r++)
            {
                for (int c = 1; c < table.GetLength(1); c++)
                {
                    if (numbers1[r - 1] == numbers2[c - 1])
                    {
                        table[r, c] = table[r - 1, c - 1] + 1;
                    }
                    else
                    {
                        table[r, c] = Math.Max(table[r - 1, c], table[r, c - 1]);
                    }
                }
            }

            int rows = numbers1.Length;
            int cols = numbers2.Length;

            Stack<int> lcs = new Stack<int>();
            while (rows > 0 && cols > 0)
            {
                if (numbers1[rows - 1] == numbers2[cols - 1])
                {
                    lcs.Push(numbers1[rows - 1]);
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

            Console.WriteLine($"{string.Join(" ", lcs)}");
            Console.WriteLine(lcs.Count);
        }
    }
}
