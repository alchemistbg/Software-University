using System;
using System.Linq;

namespace _06_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sortedNumbers = MergeSort(numbers);

            Console.WriteLine(string.Join(" ", sortedNumbers));
        }

        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            int[] left = numbers.Take(numbers.Length / 2).ToArray();
            int[] right = numbers.Skip(numbers.Length / 2).ToArray();

            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] merged = new int[left.Length + right.Length];

            int mergedIndex = 0;
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    merged[mergedIndex] = left[leftIndex];
                    leftIndex += 1;
                }
                else
                {
                    merged[mergedIndex] = right[rightIndex];
                    rightIndex += 1;
                }
                mergedIndex += 1;
            }

            while (leftIndex < left.Length)
            {
                merged[mergedIndex] = left[leftIndex];
                leftIndex += 1;
                mergedIndex += 1;
            }

            while (rightIndex < right.Length)
            {
                merged[mergedIndex] = right[rightIndex];
                rightIndex += 1;
                mergedIndex += 1;
            }

            return merged;
        }
    }
}
