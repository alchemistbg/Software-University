using System;
using System.Linq;
using System.Collections.Generic;

namespace _03_LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] lenghts = new int[numbers.Length];
            int[] prevs = new int[numbers.Length];

            int bestLength = 0;
            int bestLengthIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                prevs[i] = -1;

                int currNumber = numbers[i];
                int currBestSeq = 1;

                for (int j = i - 1; j >= 0; j--)
                {
                    int prevNumber = numbers[j];

                    if (prevNumber < currNumber && lenghts[j] + 1 >= currBestSeq)
                    {
                        currBestSeq = lenghts[j] + 1;
                        prevs[i] = j;
                    }
                }

                if (currBestSeq > bestLength)
                {
                    bestLength = currBestSeq;
                    bestLengthIndex = i;
                }

                lenghts[i] = currBestSeq;
            }

            Stack<int> lis = new Stack<int>();

            while (bestLengthIndex != -1)
            {
                lis.Push(numbers[bestLengthIndex]);
                bestLengthIndex = prevs[bestLengthIndex];
            }

            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
