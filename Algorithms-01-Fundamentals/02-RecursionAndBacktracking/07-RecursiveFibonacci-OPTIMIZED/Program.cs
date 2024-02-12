using System;
using System.Collections.Generic;

namespace _07_RecursiveFibonacci_OPTIMIZED
{
    class Program
    {
        public static Dictionary<string, long> cache;
        public static void Main(string[] args)
        {
            int stopIndex = int.Parse(Console.ReadLine());
            cache = new Dictionary<string, long>();

            Console.WriteLine(CalcRecursiveFibonacci(stopIndex));
        }

        public static long CalcRecursiveFibonacci(long number)
        {
            if (number < 2)
            {
                return 1;
            }

            string id = $"{number}";
            if (cache.ContainsKey(id))
            {
                return cache[id];
            }

            long result = CalcRecursiveFibonacci(number - 1) + CalcRecursiveFibonacci(number - 2);
            cache[id] = result;
            return result;
        }
    }
}
