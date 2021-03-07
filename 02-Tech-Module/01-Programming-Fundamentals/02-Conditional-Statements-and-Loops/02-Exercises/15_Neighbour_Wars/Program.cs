using System;

namespace _15_Neighbour_Wars
{
	class Program
	{
		static void Main(string[] args)
		{
			string pesho = "Pesho";
			string gosho = "Gosho";

			string peshoAttack = "Roundhouse kick";
			string goshoAttack = "Thunderous fist";

			int peshoDamage = int.Parse(Console.ReadLine());
			int goshoDamage = int.Parse(Console.ReadLine());

			int peshoHealth = 100;
			int goshoHealth = 100;

			int round = 1;

			while (peshoHealth > 0 && goshoHealth > 0)
			{
				if (round % 2 != 0)
				{
					goshoHealth -= peshoDamage;
					if (goshoHealth > 0)
					{
						Console.WriteLine($"{pesho} used {peshoAttack} and reduced {gosho} to {goshoHealth} health.");
					}
				}
				else
				{
					peshoHealth -= goshoDamage;
					if (peshoHealth > 0)
					{
						Console.WriteLine($"{gosho} used {goshoAttack} and reduced {pesho} to {peshoHealth} health.");
					}
				}

				if (round % 3 == 0 && peshoHealth > 0 && goshoHealth > 0)
				{
					goshoHealth += 10;
					peshoHealth += 10;
				}

				round++;
			}

			if (peshoHealth <= 0)
			{
				Console.WriteLine($"{gosho} won in {round - 1}th round.");
			}
			else if (goshoHealth <= 0)
			{
				Console.WriteLine($"{pesho} won in {round - 1}th round.");
			}
		}
	}
}
