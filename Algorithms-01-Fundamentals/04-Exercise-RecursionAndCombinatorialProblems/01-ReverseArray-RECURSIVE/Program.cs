using System;

namespace _01_ReverseArray_RECURSIVE
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split();

            ReverseArray(inputArr, 0);
            Console.WriteLine(string.Join(" ", inputArr));
        }

        private static void ReverseArray(string[] inputArr, int leftIndex)
        {
            if (leftIndex * 2 >= inputArr.Length)
            {
                return;
            }

            int rightIndex = inputArr.Length - 1 - leftIndex;

            Swap(inputArr, leftIndex, rightIndex);
            ReverseArray(inputArr, leftIndex + 1);
        }

        private static void Swap(string[] inputArr, int firstIndex, int secondIndex)
        {
            string temp = inputArr[firstIndex];
            inputArr[firstIndex] = inputArr[secondIndex];
            inputArr[secondIndex] = temp;
        }
    }
}
