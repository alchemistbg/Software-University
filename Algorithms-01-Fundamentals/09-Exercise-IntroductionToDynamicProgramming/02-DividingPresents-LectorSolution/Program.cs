using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_DividingPresents_LectorSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] presents = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> sums = GetFirstPossibleSum(presents);

            int presentsTotalSum = presents.Sum();
            int presentsHalfSum = (int)Math.Ceiling(presentsTotalSum / 2.0);

            //This is from my solution
            //int presentsHalfSum = presentsTotalSum / 2;
            
            int bobSum = presentsHalfSum;

            while (!sums.ContainsKey(bobSum))
            {
                bobSum += 1;
            }

            int alanSum = presentsTotalSum - bobSum;

            //This is my solution for switching sums
            //if (bobSum < alanSum)
            //{
            //    int temp = bobSum;
            //    bobSum = alanSum;
            //    alanSum = temp;
            //}
            int diff = bobSum - alanSum;

            Console.WriteLine($"Difference: {diff}");
            Console.WriteLine($"Alan:{alanSum} Bob:{bobSum}");

            List<int> usedNumbers = new List<int>();
            if (sums.ContainsKey(alanSum))
            {
                while (alanSum != 0)
                {
                    int currentTarget = sums[alanSum];
                    alanSum -= currentTarget;
                    usedNumbers.Add(currentTarget);
                }
            }
            Console.WriteLine($"Alan takes: {string.Join(" ", usedNumbers)}");
            Console.WriteLine("Bob takes the rest.");

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
