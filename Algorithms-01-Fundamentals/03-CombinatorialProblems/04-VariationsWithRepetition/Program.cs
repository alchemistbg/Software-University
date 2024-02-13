using System;

namespace _04_VariationsWithRepetition
{
    class Program
    {
        public static string[] elements;
        public static int k;

        public static string[] variations;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());

            variations = new string[k];
            MakeVariations(0);
        }

        private static void MakeVariations(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                variations[index] = elements[i];
                MakeVariations(index + 1);
            }
        }
    }
}
