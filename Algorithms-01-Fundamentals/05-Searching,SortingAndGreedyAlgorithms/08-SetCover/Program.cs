using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_SetCover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine()
                            .Split(", ")
                            .Select(int.Parse)
                            .ToList();

            int inputSetsNumber = int.Parse(Console.ReadLine());
            List<int[]> inputSets = new List<int[]>();
            for (int i = 0; i < inputSetsNumber; i++)
            {
                inputSets.Add(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            }

            List<int[]> selectedSets = new List<int[]>();
            while (universe.Count > 0)
            {
                var currentSet = inputSets
                                .OrderByDescending(s => s.Count(e => universe.Contains(e)))
                                .FirstOrDefault();

                selectedSets.Add(currentSet);
                inputSets.Remove(currentSet);
                foreach (var a in currentSet)
                {
                    universe.Remove(a);
                }
            }

            Console.WriteLine($"Sets to take ({selectedSets.Count}):");
            foreach (var set in selectedSets)
            {
                Console.WriteLine($"{string.Join(", ", set)}");
            }
        }
    }
}
