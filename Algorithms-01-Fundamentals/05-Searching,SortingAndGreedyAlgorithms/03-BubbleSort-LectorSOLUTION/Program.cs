using System;
using System.Linq;

namespace _03_BubbleSort_LectorSOLUTION
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void BubbleSort(int[] numbers)
        {
            bool isSorted = false;
            int sortedElements = 0;

            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < numbers.Length - sortedElements; i++)
                //for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] > numbers[i])
                    {
                        Swap(numbers, i - 1, i);
                        isSorted = false;
                        //sortedElements++;
                    }
                }
            }
        }

        private static void Swap(int[] numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}
