using System;

namespace _03_CombinationsWithRepetition
{
    class Program
    {
        public static int[] elements;
        public static int[] combinations;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            elements = new int[n];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = i + 1;
            }

            int k = int.Parse(Console.ReadLine());
            combinations = new int[k];

            MakeCombinations(0, 0);
        }

        private static void MakeCombinations(int currentIndex, int combinationIndex)
        {
            if (currentIndex >= combinations.Length)
            {
                Console.WriteLine(string.Join(" ", combinations));
                return;
            }

            for (int i = combinationIndex; i < elements.Length; i++)
            {
                combinations[currentIndex] = elements[i];
                MakeCombinations(currentIndex + 1, i);
            }
        }
    }
}
