using System;

namespace _09_Count_The_Integers
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			Boolean b = true;

			int counter = 0;

			while (b)
			{
				try
				{
					int number = int.Parse(text);
					counter++;
					text = Console.ReadLine();
				}
				catch (Exception)
				{
					b = false;
				}
			}
			Console.WriteLine(counter);
		}
	}
}
