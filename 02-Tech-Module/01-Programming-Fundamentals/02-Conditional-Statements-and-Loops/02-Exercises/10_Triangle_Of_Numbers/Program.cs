using System;

namespace _10_Triangle_Of_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = int.Parse(Console.ReadLine());

			for (int i = 1; i <= counter; i++)
			{
				if (i == 1)
				{
					Console.Write(i);
				}
				else
				{
					Console.Write(i);
					for (int k = 1; k < i; k++)
					{
						Console.Write(" " + i);
					}
				}
				Console.WriteLine();
			}
		}
	}
}
