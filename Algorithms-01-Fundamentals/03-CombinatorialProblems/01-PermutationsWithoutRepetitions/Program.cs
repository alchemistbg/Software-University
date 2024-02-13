using System;

namespace _01_PermutationsWithoutRepetitions
{
    class Program
    {
        static string[] input;
        static void Main(string[] args)
        {
            input = Console.ReadLine().Split();
            Permnute(0);
        }

        private static void Permnute(int permuteIndex)
        {
            if (permuteIndex >= input.Length)
            {
                Console.WriteLine(string.Join(" ", input));
                return;
            }

            Permnute(permuteIndex + 1);

            for (int i = permuteIndex + 1; i < input.Length; i++)
            {
                Swap(permuteIndex, i);
                Permnute(permuteIndex + 1);
                Swap(permuteIndex, i);

            }
        }

        private static void Swap(int firstElement, int secondElement)
        {
            string temp = input[firstElement];
            input[firstElement] = input[secondElement];
            input[secondElement] = temp;
        }
    }
}
