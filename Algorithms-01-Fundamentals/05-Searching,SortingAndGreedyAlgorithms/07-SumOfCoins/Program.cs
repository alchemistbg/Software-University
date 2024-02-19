using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] sortedCoins = coins.OrderByDescending(coin => coin).ToArray();
            
            int initialSum = int.Parse(Console.ReadLine());
            int remainingSum = initialSum;
            
            int totalCoins = 0;
            Dictionary<int, int> selectedCoins = new Dictionary<int, int>();

            for (int i = 0; i < sortedCoins.Length; i++)
            {
                if (remainingSum >= sortedCoins[i])
                {
                    int currentCoins = remainingSum / sortedCoins[i];
                    totalCoins += currentCoins;
                    remainingSum = remainingSum - (currentCoins * sortedCoins[i]);

                    selectedCoins.Add(sortedCoins[i], currentCoins);
                }
            }

            if (remainingSum > 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"Number of coins to take: {totalCoins}");
                foreach (var kvp in selectedCoins)
                {
                    Console.WriteLine($"{kvp.Value} coin(s) with value {kvp.Key}");
                }
            }
        }
    }
}
