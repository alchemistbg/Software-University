using System;

namespace _10_Pairs_By_Difference
{
	class Program
	{
		static void Main(string[] args)
		{
			string queryString = Console.ReadLine();
			int diff = int.Parse(Console.ReadLine());
			string[] queryArrayAsText = queryString.Split(' ');
			int[] queryArrpayAsNumbers = new int[queryArrayAsText.Length];
			for (int i = 0; i < queryArrayAsText.Length; i++)
			{
				queryArrpayAsNumbers[i] = int.Parse(queryArrayAsText[i]);
			}

			int counter = 0;
			for (int i = 0; i < queryArrpayAsNumbers.Length; i++)
			{
				for (int k = i; k < queryArrpayAsNumbers.Length; k++)
				{
					if (Math.Abs(queryArrpayAsNumbers[i] - queryArrpayAsNumbers[k]) == diff)
					{
						counter++;
					}
				}
			}
			Console.WriteLine(counter);
		}
	}
}
