using System;

namespace _03_Water_Overflow
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputNum = int.Parse(Console.ReadLine());
			int tankMaxCapacity = 255;
			int tankCurrentFill = 0;

			for (int i = 0; i < inputNum; i++)
			{
				int litres = int.Parse(Console.ReadLine());
				if (tankCurrentFill + litres > tankMaxCapacity)
				{
					Console.WriteLine("Insufficient capacity!");
				}
				else
				{
					tankCurrentFill += litres;
				}
			}
			Console.WriteLine(tankCurrentFill);
		}
	}
}
