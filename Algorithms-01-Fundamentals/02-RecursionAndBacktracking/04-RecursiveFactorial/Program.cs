using System;

namespace _04_RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFactoriel(number));
        }

        static long CalcFactoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalcFactoriel(n - 1);
        }
    }
}
