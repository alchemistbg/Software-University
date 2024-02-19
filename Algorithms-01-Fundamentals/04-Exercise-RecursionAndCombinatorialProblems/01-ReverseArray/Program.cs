using System;

namespace _01_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(" ");
            string[] outputArr = new string[inputArr.Length];

            for (int i = 0; i < outputArr.Length; i++)
            {
                outputArr[i] = inputArr[outputArr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", outputArr));
        }


    }
}
