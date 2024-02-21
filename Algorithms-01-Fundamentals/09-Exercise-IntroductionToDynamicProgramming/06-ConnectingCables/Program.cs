using System;
using System.Linq;

namespace _06_ConnectingCables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] permutedCables = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sortedCables = permutedCables.OrderBy(e => e).ToArray();

            int connectedPairs = FindConnectedPairs(permutedCables, sortedCables);

            Console.WriteLine($"Maximum pairs connected: {connectedPairs}");
        }

        private static int FindConnectedPairs(int[] permutedCables, int[] sortedCables)
        {
            int[,] table = new int[permutedCables.Length + 1, sortedCables.Length + 1];

            for (int r = 1; r < table.GetLength(0); r++)
            {
                for (int c = 1; c < table.GetLength(1); c++)
                {
                    if (permutedCables[r - 1] == sortedCables[c - 1])
                    {
                        table[r, c] = table[r - 1, c - 1] + 1;
                    }
                    else
                    {
                        table[r, c] = Math.Max(table[r - 1, c], table[r, c - 1]);
                    }
                }
            }

            return table[permutedCables.Length, sortedCables.Length];
        }
    }
}
