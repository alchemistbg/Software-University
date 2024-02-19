using System;
using System.Linq;

namespace _03_BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        /*
         * My implementation
         */
        //private static void BubbleSort(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < numbers.Length; j++)
        //        {
        //            //Console.WriteLine($"{i}; {j}");
        //            if (numbers[i] > numbers[j])
        //            {
        //                Swap(numbers, i, j);
        //            }
        //        }
        //    }
        //}

        /*
         * Ipmlementation from lecture
         * There is another implementation in the lecture
         */
        private static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j < numbers.Length - i; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        Swap(numbers, j - 1, j);
                    }
                }
            }
        }

        /* This one was found on stackoverflow
         * https://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp
         */
        //private static void BubbleSort(int[] numbers)
        //{
        //    int arrLength = numbers.Length;
        //    for (int i = 0; i < numbers.Length - 1; i++, arrLength--)
        //    {
        //        for (int j = 0; j < arrLength - 1; j++)
        //        {
        //            Console.WriteLine($"{i}; {j}");
        //            if (numbers[j] > numbers[j + 1])
        //            {
        //                Swap(numbers, j, j + 1);
        //            }
        //        }
        //    }
        //}

        private static void Swap(int[] numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}
