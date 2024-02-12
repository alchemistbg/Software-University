using System;

namespace _02_RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            print(counter);
        }

        static void print(int n) {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));
            print(n - 1);
            Console.WriteLine(new string('#', n));
        }
    }
}
