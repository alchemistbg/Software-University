using System;

namespace _02_Ladybugs
{
	class Program
	{
		static void Main(string[] args)
		{
			long fieldSize = long.Parse(Console.ReadLine());
			long[] field = new long[fieldSize];
			long[] ladyBugs = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			for (long i = 0; i < ladyBugs.Length; i++)
			{
				if (ladyBugs[i] >= 0 && ladyBugs[i] < field.Length)
				{
					field[ladyBugs[i]] = 1;
				}
			}

			string input = Console.ReadLine();
			while (input != "end")
			{
				string[] inputArr = input.Split(' ');
				long ladyBugIndex = long.Parse(inputArr[0]);
				string flyDirection = inputArr[1];
				long flyDistance = long.Parse(inputArr[2]);

				if (ladyBugIndex >= 0 && ladyBugIndex < field.Length && field[ladyBugIndex] == 1)
				{
					field[ladyBugIndex] = 0;
					long newCell = 0;
					if (flyDirection == "right")
					{
						newCell = ladyBugIndex + flyDistance;
					}
					else if (flyDirection == "left")
					{
						newCell = ladyBugIndex - flyDistance;
					}

					while (true)
					{
						if (newCell >= 0 && newCell < field.Length)
						{
							if (field[newCell] == 0)
							{
								field[newCell] = 1;
								break;
							}
							else
							{
								if (flyDirection == "right")
								{
									newCell += flyDistance;
								}
								else
								{
									newCell -= flyDistance;
								}
							}
						}
						else
						{
							break;
						}
					}
				}

				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(" ", field));
		}
	}
}
