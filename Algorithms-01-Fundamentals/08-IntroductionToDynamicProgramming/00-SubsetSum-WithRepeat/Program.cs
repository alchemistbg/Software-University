using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_SubsetSum_WithRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 5, 2 };
            int targetSum = 999;

            bool[] sums = new bool[targetSum + 1];
            sums[0] = true;

            for (int sum = 0; sum < sums.Length; sum++)
            {
                if (sums[sum])
                {
                    foreach (int number in numbers)
                    {
                        var newSum = sum + number;

                        if (newSum <= targetSum)
                        {
                            sums[newSum] = true;
                        }
                    }
                }
            }

            Console.WriteLine(sums[targetSum]);

            List<int> usedNumbers = new List<int>();

            while (targetSum > 0)
            {
                foreach (int number in numbers)
                {
                    int prevSum = targetSum - number;
                    if (prevSum >= 0 && sums[prevSum])
                    {
                        usedNumbers.Add(number);
                        targetSum = prevSum;
                    }
                }
            }

            Console.WriteLine(string.Join("; ", usedNumbers.OrderBy(n => n)));
        }
    }
}
