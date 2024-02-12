using System;

namespace _03_Generating01Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int vectorLength = int.Parse(Console.ReadLine());
            int[] vector = new int[vectorLength];
            GenerateVector(vector, 0);
        }

        static void GenerateVector(int[] vector, int currentIndex)
        {
            if (currentIndex >= vector.Length)
                Console.WriteLine(string.Join("", vector));
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[currentIndex] = i;
                    GenerateVector(vector, currentIndex + 1);
                }
            }

        }
    }
}
