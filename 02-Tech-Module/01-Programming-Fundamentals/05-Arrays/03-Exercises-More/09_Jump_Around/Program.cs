using System;
using System.Linq;

namespace _09_Jump_Around
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int currentPos = 0;
			int step = numbers[currentPos];
			int jumpSum = numbers[currentPos];

			for (; ; )
			{
				if (step >= 0 && step < numbers.Length)
				{
					if (currentPos + step >= numbers.Length)
					{
						currentPos -= step;
					}
					else if (currentPos + step < numbers.Length)
					{
						currentPos += step;
					}

					if (currentPos < 0)
					{
						break;
					}
					else
					{

						jumpSum += numbers[currentPos];
						step = numbers[currentPos];
					}
				}
				else
				{
					break;
				}
			}

			Console.WriteLine(jumpSum);
		}
	}
}
