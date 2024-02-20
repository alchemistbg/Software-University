using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_SubsetSum_NoRepeat
{
    class Program
    {
        static HashSet<int> possibleSums;
        static void Main(string[] args)
        {
            int targetSum = 6;
            int[] numbers = new int[] { 3, 5, 1, 4, 2};

            possibleSums = GetAllSums(numbers);
            Console.WriteLine(string.Join(" ", possibleSums));

            Dictionary<int, int> combinations = GetFirstPossibleSum(numbers);
            List<int> usedNumbers = new List<int>();
            if (!combinations.ContainsKey(targetSum))
            {
                //Console.WriteLine("FUCK");
            }
            else
            {
                while (targetSum != 0)
                {
                    int currentTarget = combinations[targetSum];
                    targetSum -= currentTarget;
                    usedNumbers.Add(currentTarget);
                }

                Console.WriteLine(string.Join(" + ", usedNumbers));
            }

        }

        private static HashSet<int> GetAllSums(int[] numbers)
        {
            HashSet<int> sums = new HashSet<int> { 0 };

            foreach (int number in numbers)
            {
                HashSet<int> newSums = new HashSet<int>();
                foreach (int sum in sums)
                {
                    int newSum = number + sum;
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
