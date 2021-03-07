using System;

namespace _11_Price_Change_Alert
{
	class Program
	{
		static void Main()
		{
			int numOfPrices = int.Parse(Console.ReadLine());
			double treshhold = double.Parse(Console.ReadLine());
			double priceCurrent = double.Parse(Console.ReadLine());

			for (int i = 0; i < numOfPrices - 1; i++)
			{
				double priceNext = double.Parse(Console.ReadLine());
				double difference = calcPercentage(priceCurrent, priceNext);
				bool isSignificantDifference = isThereDiff(difference, treshhold);
				string message = printMessage(priceNext, priceCurrent, difference, isSignificantDifference);
				Console.WriteLine(message);
				priceCurrent = priceNext;
			}
		}

		private static string printMessage(double priceNext, double priceCurrent, double difference, bool isSignificantDifference)
		{
			string message = "";
			if (difference == 0)
			{
				message = string.Format("NO CHANGE: {0}", priceNext);
			}
			else if (!isSignificantDifference)
			{
				message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", priceCurrent, priceNext, difference * 100);
			}
			else if (isSignificantDifference && (difference > 0))
			{
				message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", priceCurrent, priceNext, difference * 100);
			}
			else if (isSignificantDifference && (difference < 0))
				message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", priceCurrent, priceNext, difference * 100);
			return message;
		}

		private static bool isThereDiff(double difference, double treshold)
		{
			if (Math.Abs(difference) >= treshold)
			{
				return true;
			}
			return false;
		}

		private static double calcPercentage(double price1, double price2)
		{
			double percentage = (price2 - price1) / price1;
			return percentage;
		}
	}
}
