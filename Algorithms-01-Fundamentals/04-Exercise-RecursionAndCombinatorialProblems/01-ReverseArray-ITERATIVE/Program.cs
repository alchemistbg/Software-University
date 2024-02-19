using System;

namespace _01_ReverseArray_ITERATIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(" ");;

            for (int leftIndex = 0; leftIndex < inputArr.Length/2; leftIndex++)
            {
                int rightIndex = inputArr.Length - 1 - leftIndex;
                Swap(inputArr, leftIndex, rightIndex);
            }

            Console.WriteLine(string.Join(" ", inputArr));
        }

        private static void Swap(string[] inputArr, int firstIndex, int secondIndex)
        {
            string temp = inputArr[firstIndex];
            inputArr[firstIndex] = inputArr[secondIndex];
            inputArr[secondIndex] = temp;
        }
    }
}
