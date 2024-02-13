using System;

namespace _06_CombinationsWithRepetition
{
    class Program
    {
        public static string[] elements;
        public static int k;

        public static string[] combinations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());

            combinations = new string[k];
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
                MakeCombinations(currentIndex + 1, i + 1);
            }
        }
    }
}
