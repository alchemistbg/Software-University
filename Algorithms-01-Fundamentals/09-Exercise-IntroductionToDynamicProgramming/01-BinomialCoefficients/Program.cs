using System;
using System.Collections.Generic;

namespace _01_BinomialCoefficients
{
    // The solution of this task is the same as the one for "N Choose K Count" task from  "Combinatorial Problems".
    // Just memoization was added in order to speed up the calculations
    class Program
    {
        public static Dictionary<string, long> cache;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            cache = new Dictionary<string, long>();
            Console.WriteLine(GetBinom(n, k));
        }

        private static long GetBinom(int row, int col)
        {
            string id = $"{row} {col}";
            if (cache.ContainsKey(id))
            {
                return cache[id];
            }

            if (row < 2 || col == 0 || row == col)
            {
                return 1;
            }

            long result = GetBinom(row - 1, col - 1) + GetBinom(row - 1, col);
            cache[id] = result;
            return result;
        }
    }
}
