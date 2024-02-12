using System;

namespace _01_RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] stringArray = Console.ReadLine().Split(" ");
            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }

            int arraySum = CalcArraySum(intArray, 0);
            Console.WriteLine(arraySum);
        }

        static int CalcArraySum(int[] array, int currIndex)
        {
            if (currIndex >= array.Length)
            {
                return 0;
            }

            return array[currIndex] + CalcArraySum(array, currIndex + 1);
        }
    }
}
