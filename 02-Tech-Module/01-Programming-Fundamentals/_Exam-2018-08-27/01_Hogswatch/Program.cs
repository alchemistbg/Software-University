using System;

namespace Hogswatch
{
	class Program
	{
		static void Main(string[] args)
		{
			int homes = int.Parse(Console.ReadLine());
			int initialPresents = int.Parse(Console.ReadLine());

			int visitedHomes = 0;
			int remainingHomes = homes;

			int leftoverPresents = initialPresents;
			int aditionalPresents = 0;
			int totalAditionalPresents = 0;

			int timesBack = 0;
			for (int i = 0; i < homes; i++)
			{
				visitedHomes++;
				remainingHomes--;

				int currentPresents = int.Parse(Console.ReadLine());

				if (leftoverPresents >= currentPresents)
				{
					leftoverPresents -= currentPresents;
				}
				else
				{
					timesBack++;
					int needToTakePresents = currentPresents - leftoverPresents;
					aditionalPresents = (initialPresents / visitedHomes) * remainingHomes + needToTakePresents;
					totalAditionalPresents += aditionalPresents;
					leftoverPresents += aditionalPresents;
					leftoverPresents -= currentPresents;
				}

			}

			if (timesBack == 0)
			{
				Console.WriteLine(leftoverPresents);
			}
			else
			{
				Console.WriteLine(timesBack);
				Console.WriteLine(totalAditionalPresents);
			}
		}
	}
}
