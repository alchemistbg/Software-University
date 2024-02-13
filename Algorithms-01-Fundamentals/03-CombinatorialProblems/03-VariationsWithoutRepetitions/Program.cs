using System;

namespace _03_VariationsWithoutRepetitions
{
    class Program
    {
        public static string[] elements;
        public static int k;

        public static string[] variations;
        public static bool[] used;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            k = int.Parse(Console.ReadLine());

            variations = new string[k];
            used = new bool[elements.Length];
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
                //if (!used[i])
                //{
                    //used[i] = true;
                    variations[index] = elements[i];
                    MakeVariations(index + 1);
                    //used[i] = false;
                //}
            }
        }
    }
}
