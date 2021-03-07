using System;

namespace _14_Boat_Simulator
{
	class Program
	{
		static void Main(string[] args)
		{
			char firstBoat = char.Parse(Console.ReadLine());
			char secondBoat = char.Parse(Console.ReadLine());

			int fbTiles = 0;
			int sbTiles = 0;

			bool isBreak = false;
			char winner = (char)0;

			int num = int.Parse(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				string input = Console.ReadLine();
				if (input.Equals("UPGRADE"))
				{
					firstBoat = (char)((int)firstBoat + 3);
					secondBoat = (char)((int)secondBoat + 3);
				}
				else
				{
					if (i % 2 != 0)
					{
						fbTiles += input.Length;
						if (fbTiles >= 50)
						{
							winner = firstBoat;
							Console.WriteLine(winner);
							isBreak = true;
							break;
						}
					}
					else
					{
						sbTiles += input.Length;
						if (sbTiles >= 50)
						{
							winner = secondBoat;
							Console.WriteLine(winner);
							isBreak = true;
							break;
						}
					}
				}
			}

			if (!isBreak)
			{
				if (fbTiles > sbTiles)
				{
					winner = firstBoat;
				}
				else
				{
					winner = secondBoat;
				}

				Console.WriteLine(winner);
			}
		}
	}
}
