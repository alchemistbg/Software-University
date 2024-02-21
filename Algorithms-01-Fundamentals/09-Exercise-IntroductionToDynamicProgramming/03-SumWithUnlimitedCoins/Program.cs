using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SumWithUnlimitedCoins
{
	//https://www.geeksforgeeks.org/coin-change-dp-7/
    class Program
	{
		public static void Main()
		{
			int[] coins = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetSum = int.Parse(Console.ReadLine());

			int sumsCount = CountSumsCombinations(coins, targetSum);
            Console.WriteLine(sumsCount);
		}

		static int CountSumsCombinations(int[] coins, int target)
		{
			int[] sumsTable = new int[target + 1];
			
			sumsTable[0] = 1;

			for (int i = 0; i < coins.Length; i++) { 
				for (int j = coins[i]; j <= target; j++)
                {
					sumsTable[j] += sumsTable[j - coins[i]];
                }
			}

			return sumsTable[target];
		}
	}
}
