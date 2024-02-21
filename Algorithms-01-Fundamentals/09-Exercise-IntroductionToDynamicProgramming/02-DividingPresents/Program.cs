using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_DividingPresents
{
    //This solution works but needs optimization. It runs out of memory in some cases!
    class Program
    {
        static void Main(string[] args)
        {
            int[] presents = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int presentsTotalSum = presents.Sum();
            int presentsHalfSum = presents.Sum() / 2;
            ;
            int[] sums = CalcAllSums(presents).OrderBy(e => e).ToArray();

            int bobSum = sums[sums.Length - 1];
            int bestDiff = sums[sums.Length - 1] - presentsHalfSum;
            for (int i = sums.Length - 2; i >= 0; i--)
            {
                int currentDiff = sums[i] - presentsHalfSum;
                if (Math.Abs(currentDiff) < Math.Abs(bestDiff))
                {
                    bestDiff = currentDiff;
                    bobSum = sums[i];
                }
                else
                {
                    break;
                }
            }

            int alanSum = presentsTotalSum - bobSum;
            if (bobSum < alanSum)
            {
                int temp = bobSum;
                bobSum = alanSum;
                alanSum = temp;
            }
            int diff = bobSum - alanSum;

            Console.WriteLine($"Difference: {diff}");
            Console.WriteLine($"Alan:{alanSum} Bob:{bobSum}");

            Dictionary<int, int> combinations = GetFirstPossibleSum(presents);
            List<int> usedNumbers = new List<int>();
            if (combinations.ContainsKey(alanSum))
            {
                while (alanSum != 0)
                {
                    int currentTarget = combinations[alanSum];
                    alanSum -= currentTarget;
                    usedNumbers.Add(currentTarget);
                }
            }
            Console.WriteLine($"Alan takes: {string.Join(" ", usedNumbers)}");
            Console.WriteLine("Bob takes the rest.");
        }

        private static HashSet<int> CalcAllSums(int[] presents)
        {
            HashSet<int> sums = new HashSet<int> { 0 };

            foreach (int present in presents)
            {
                HashSet<int> newSums = new HashSet<int>();
                foreach (int sum in sums)
                {
                    int newSum = present + sum;
                    newSums.Add(newSum);
                }

                sums.UnionWith(newSums);
            }

            return sums;
        }

        private static Dictionary<int, int> GetFirstPossibleSum(int[] numbers)
        {
            Dictionary<int, int> sums = new Dictionary<int, int> { { 0, 0 } };

            foreach (int num in numbers)
            {
                int[] currentSums = sums.Keys.ToArray();

                foreach (int sum in currentSums)
                {
                    int newSum = sum + num;
                    if (!sums.ContainsKey(newSum))
                    {
                        sums.Add(newSum, num);
                    }
                }
            }
            return sums;
        }
    }
}
