using System;
using System.Linq;

namespace _00._1_GeneratingCombinations
{
    class Program
    {
        //This task is from the 2018 course edition
        static void Main(string[] args)
        {
            //This uses Linq
            //int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int k = int.Parse(Console.ReadLine());
            GenerateCombinations(input, new int[k], 0, 0);
        }

        static void GenerateCombinations(int[] set, int[] vector, int index, int border)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenerateCombinations(set, vector, index + 1, i + 1);
                }

            }
        }
    }
}
