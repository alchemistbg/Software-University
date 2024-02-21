using System;

namespace _05_WordDifferences
{
    // This task is about transforming one string to another. "Minimum edit distance" is of the same type.
    // Information about the problem could be found on the following page:
    // https://en.wikipedia.org/wiki/Edit_distance
    // This solution uses 
    // https://en.wikipedia.org/wiki/Longest_common_subsequence_problem
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();

            int operations = TransformWords(word1, word2);
            Console.WriteLine($"Deletions and Insertions: {operations}");
        }

        private static int TransformWords(string word1, string word2)
        {
            int[,] operationsMatrix = new int[word1.Length + 1, word2.Length + 1];
            //operationsMatrix[0, 0] = 0;

            for (int r = 0; r < operationsMatrix.GetLength(0); r++)
            {
                operationsMatrix[r, 0] = r;
            }

            for (int c = 0; c < operationsMatrix.GetLength(1); c++)
            {
                operationsMatrix[0, c] = c;
            }

            for (int r = 1; r < operationsMatrix.GetLength(0); r++)
            {
                for (int c = 1; c < operationsMatrix.GetLength(1); c++)
                {
                    
                    if (word1[r - 1] == word2[c - 1])
                    {
                        operationsMatrix[r, c] = operationsMatrix[r - 1, c - 1];
                    }
                    else
                    {
                        operationsMatrix[r, c] = Math.Min(operationsMatrix[r - 1, c], operationsMatrix[r, c - 1]) + 1;
                    }
                }
            }

            return operationsMatrix[word1.Length, word2.Length];
        }
    }
}
