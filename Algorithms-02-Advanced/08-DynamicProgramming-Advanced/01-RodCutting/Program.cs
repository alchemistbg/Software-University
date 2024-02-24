using System;
using System.Linq;

namespace _01_RodCutting
{
    class Program
    {
        static int[] bestPrices;
        static int[] prevs;

        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int length = int.Parse(Console.ReadLine());

            bestPrices = new int[length + 1];
            prevs = new int[length + 1];

            int solution = CutRod(prices, prevs, length);

            Console.WriteLine(solution);

            while (length != 0)
            {
                Console.Write($"{prevs[length]} ");
                length -= prevs[length];
            }
        }

        private static int CutRod(int[] prices, int[] prev, int length)
        {
            if (length == 0)
            {
                return 0;
            }

            if (bestPrices[length] != 0)
            {
                return bestPrices[length];
            }

            int bestPrice = prices[length];
            int bestPrev = length;

            for (int i = 1; i <= length; i++)
            {
                int currentPrice = prices[i] + CutRod(prices, prev, length - i);

                if (currentPrice > bestPrice)
                {
                    bestPrice = currentPrice;
                    bestPrev = i;
                }
            }

            bestPrices[length] = bestPrice; 
            prevs[length] = bestPrev;

            return bestPrice;
        }

    }
}
