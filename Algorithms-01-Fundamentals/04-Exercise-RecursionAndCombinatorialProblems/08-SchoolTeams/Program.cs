using System;
using System.Collections.Generic;

namespace _08_SchoolTeams
{
    class Program
    {
        public static string[] girls;
        public static string[] boys;

        public static List<string> girlsCombinations;
        public static List<string> boysCombinations;

        public static string[] girlsTempCombinations;
        public static string[] boysTempCombinations;
        public static void Main(string[] args)
        {
            girls = Console.ReadLine().Split(", ");
            girlsCombinations = new List<string>();
            girlsTempCombinations = new string[3];
            MakeCombination("girls", girls, girlsTempCombinations, 0, 0);

            boys = Console.ReadLine().Split(", ");
            boysCombinations = new List<string>();
            boysTempCombinations = new string[2];
            MakeCombination("boys", boys, boysTempCombinations, 0, 0);

            for (int i = 0; i < girlsCombinations.Count; i++)
            {
                for (int k = 0; k < boysCombinations.Count; k++)
                {
                    Console.Write(girlsCombinations[i]);
                    Console.Write(", ");
                    Console.Write(boysCombinations[k]);
                    Console.WriteLine();
                    //Console.WriteLine($"{girlsCombinations[i]}, {boysCombinations[k]}");
                }
            }
        }

        public static void MakeCombination(string gender, string[] elements, string[] tempCombinations, int currentIndex, int combinationIndex)
        {
            if (gender == "girls" && currentIndex >= girlsTempCombinations.Length)
            {
                string combination = string.Join(", ", girlsTempCombinations);
                girlsCombinations.Add(combination);
                return;
            }

            if (gender == "boys" && currentIndex >= boysTempCombinations.Length)
            {
                string combination = string.Join(", ", boysTempCombinations);
                boysCombinations.Add(combination);
                return;
            }

            for (int i = combinationIndex; i < elements.Length; i++)
            {
                tempCombinations[currentIndex] = elements[i];
                MakeCombination(gender, elements, tempCombinations, currentIndex + 1, i + 1);
            }
        }
    }
}
