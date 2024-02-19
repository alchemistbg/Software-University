using System;
using System.Linq;

namespace _02_SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SelectionSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int minIndex = i;
                //int minNumber = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //if (numbers[j] < minNumber)
                    //{
                    //    minIndex = j;
                    //    minNumber = numbers[j];
                    //}
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //Swap(numbers, i, minIndex);
                Swap(numbers, i, minIndex);
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
