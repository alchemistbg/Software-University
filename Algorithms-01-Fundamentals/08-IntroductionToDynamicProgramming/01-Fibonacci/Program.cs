using System;
using System.Collections.Generic;

namespace _01_Fibonacci
{
    class Program
    {
        public static Dictionary<int, long> cache;
        public static void Main(string[] args)
        {
            int stopIndex = int.Parse(Console.ReadLine());
            cache = new Dictionary<int, long>();

            Console.WriteLine(CalcRecursiveFibonacci(stopIndex));
        }

        public static long CalcRecursiveFibonacci(int number)
        {
            if (number <= 2)
            {
                return 1;
            }

            if (cache.ContainsKey(number))
            {
                return cache[number];
            }

            long result = CalcRecursiveFibonacci(number - 1) + CalcRecursiveFibonacci(number - 2);
            cache[number] = result;
            
            return result;
        }
    }
}
