using System;

namespace _01_Poke_Mon
{
	class Program
	{
		static void Main(string[] args)
		{
			int pokePowerInitial = int.Parse(Console.ReadLine());
			int pokeTargets = int.Parse(Console.ReadLine());
			int exFactor = int.Parse(Console.ReadLine());

			int pokeCounter = 0;

			int pokePowerCurrent = pokePowerInitial;
			double pokePercentage = 100.0;

			while (pokePowerCurrent >= pokeTargets)
			{
				pokePowerCurrent -= pokeTargets;
				pokeCounter++;
				pokePercentage = 1.0 * pokePowerCurrent / pokePowerInitial * 100;

				if (pokePercentage == 50.0)
				{
					try
					{
						pokePowerCurrent = pokePowerCurrent / exFactor;
					}
					catch (DivideByZeroException e)
					{

					}
				}
			}
			Console.WriteLine($"{pokePowerCurrent}\n{pokeCounter}");
		}
	}
}
