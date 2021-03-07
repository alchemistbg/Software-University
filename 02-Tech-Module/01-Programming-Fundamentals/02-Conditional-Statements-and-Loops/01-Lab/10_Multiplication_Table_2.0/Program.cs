using System;

namespace _10_Multiplication_Table_2._0
{
	class Program
	{
		static void Main(string[] args)
		{
			int baseNumber = int.Parse(Console.ReadLine());
			int counter = int.Parse(Console.ReadLine());

			if (counter > 10)
			{
				Console.WriteLine($"{baseNumber} X {counter} = " + (baseNumber * counter));
			}
			else
			{
				for (int i = counter; i < 11; i++)
				{
					Console.WriteLine($"{baseNumber} X {i} = " + (baseNumber * i));
				}
			}
		}
	}
}
