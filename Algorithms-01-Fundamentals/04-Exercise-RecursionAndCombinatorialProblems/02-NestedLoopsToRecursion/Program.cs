using System;

namespace _02_NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineLength = int.Parse(Console.ReadLine());
            int[] line = new int[lineLength];
            MimicLoops(0, lineLength, line);
        }

        private static void MimicLoops(int currentIndex, int lineLength, int[] line)
        {
            if (currentIndex == line.Length)
            {
                Console.WriteLine(string.Join(" ", line));
                return;
            }

            for (int i = 0; i < lineLength; i++)
            {
                line[currentIndex] = i + 1;
                MimicLoops(currentIndex + 1, lineLength, line);
            }
        }
    }
}
