using System;

namespace _07_RecursiveFibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            int stopIndex = int.Parse(Console.ReadLine());
            //Console.WriteLine(CalcRecursiveFibonacci(0, 1, 0, stopIndex));
            Console.WriteLine(CalcRecursiveFibonacci(stopIndex));
        }

        //public static int CalcRecursiveFibonacci(int firstNumber, int secondNumber, int currentIndex, int stopIndex)
        //{
        //    if (stopIndex == 0 || stopIndex == 1)
        //    {
        //        return 1;
        //    }

        //    int fibonacciNumber = firstNumber + secondNumber;

        //    if (currentIndex == stopIndex - 1)
        //    {
        //        return fibonacciNumber;
        //    }
        //    else
        //    {
        //        return CalcRecursiveFibonacci(secondNumber, fibonacciNumber, currentIndex + 1, stopIndex);
        //    }
        //}

        //This realization throws "TIMI LIMIT" on judge
        public static long CalcRecursiveFibonacci(long number)
        {
            if (number < 2)
            {
                return 1;
            }

            else
            {
                return CalcRecursiveFibonacci(number - 1) + CalcRecursiveFibonacci(number - 2);
            }
        }
    }
}
