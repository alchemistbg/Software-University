using System;
using System.Collections.Generic;

namespace _02_PermutationsWithRepetition
{
    class Program
    {
        static string[] input;
        static void Main(string[] args)
        {
            input = Console.ReadLine().Split();
            Permute(0);
        }

        static void Permute(int permuteIndex)
        {
            if (permuteIndex >= input.Length)
            {
                Console.WriteLine(string.Join(" ", input));
                return;
            }

            var swapped = new HashSet<string> { input[permuteIndex] };
            Permute(permuteIndex + 1);
            for (int i = permuteIndex + 1; i < input.Length; i++)
            {
                if (!swapped.Contains(input[i]))
                {
                    Swap(permuteIndex, i);
                    Permute(permuteIndex + 1);
                    Swap(permuteIndex, i);
                    swapped.Add(input[i]);
                }
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
