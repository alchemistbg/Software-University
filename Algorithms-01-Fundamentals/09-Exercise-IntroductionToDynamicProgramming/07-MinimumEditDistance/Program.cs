using System;

namespace _07_MinimumEditDistance
{
    // This task is about transforming one string to another. "Word differences" is of the same type.
    // Information about the problem could be found on the following page:
    // https://en.wikipedia.org/wiki/Edit_distance
    // This solution uses 
    // https://en.wikipedia.org/wiki/Levenshtein_distance
    class Program
    {
        static void Main(string[] args)
        {
            int replaceCost = int.Parse(Console.ReadLine());
            int insertCost = int.Parse(Console.ReadLine());
            int deleteCost = int.Parse(Console.ReadLine());

            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            int result = GetMinimumEditDistance(string1, string2, replaceCost, insertCost, deleteCost);

            Console.WriteLine($"Minimum edit distance: {result}");
        }

        private static int GetMinimumEditDistance(string string1, string string2, int replaceCost, int insertCost, int deleteCost)
        {
            int[,] table = new int[string2.Length + 1, string1.Length + 1];

            for (int r = 1; r < table.GetLength(0); r++)
            {
                table[r, 0] = r * insertCost;
            }

            for (int c = 1; c < table.GetLength(1); c++)
            {
                table[0, c] = c * deleteCost;
            }

            for (int r = 1; r < table.GetLength(0); r++)
            {
                for (int c = 1; c < table.GetLength(1); c++)
                {
                    if (string2[r - 1] != string1[c - 1])
                    {
                        int insert = table[r - 1, c] + insertCost;
                        int replace = table[r - 1, c - 1] + replaceCost;
                        int delete = table[r, c - 1] + deleteCost;

                        table[r, c] = Math.Min(Math.Min(delete, insert), replace);
                    }
                    else
                    {
                        table[r, c] = table[r - 1, c - 1];
                    }
                }
            }

            return table[table.GetLength(0) - 1, table.GetLength(1) - 1];
        }
    }
}
