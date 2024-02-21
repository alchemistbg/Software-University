using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SumWithLimitedCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetSum = int.Parse(Console.ReadLine());

            Dictionary<int, int> sums = GetPossibleSumsCount(numbers);

            Console.WriteLine(sums[targetSum]);
        }

        private static Dictionary<int, int> GetPossibleSumsCount(int[] numbers)
        {
            Dictionary<int, int> sums = new Dictionary<int, int> { { 0, 1 } };

            foreach (int num in numbers)
            {
                int[] currentSums = sums.Keys.ToArray();

                foreach (int sum in currentSums)
                {
                    int newSum = sum + num;
                    if (!sums.ContainsKey(newSum))
                    {
                        sums.Add(newSum, 1);
                    }
                    else
                    {
                        sums[newSum] += 1;
                    }
                }
            }
            return sums;
        }
    }
}
