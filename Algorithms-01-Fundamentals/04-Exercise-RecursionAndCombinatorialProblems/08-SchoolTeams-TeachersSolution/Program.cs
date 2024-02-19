using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_SchoolTeams_TeachersSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] girls = Console.ReadLine().Split(", ");
            string[] girlsComb = new string[3];
            List<string[]> girlsList = new List<string[]>();
            MakeCombination(0, 0, girlsComb, girls, girlsList);

            string[] boys = Console.ReadLine().Split(", ");
            string[] boysComb = new string[2];
            List<string[]> boysList = new List<string[]>();
            MakeCombination(0, 0, boysComb, boys, boysList);

            for (int i = 0; i < girlsList.Count; i++)
            {
                for (int k = 0; k < boysList.Count; k++)
                {
                    Console.WriteLine($"{string.Join(", ", girlsList[i])}, {string.Join(", ", boysList[k])}");
                }
            }
        }

        private static void MakeCombination(int cellIndex, int elementIndex, string[] combinations, string[] elements, List<string[]> result)
        {
            if (cellIndex >= combinations.Length)
            {
                result.Add(combinations.ToArray());
                return;
            }

            for (int i = elementIndex; i < elements.Length; i++)
            {
                combinations[cellIndex] = elements[i];
                MakeCombination(cellIndex + 1, i + 1, combinations, elements, result);
            }
        }
    }
}
