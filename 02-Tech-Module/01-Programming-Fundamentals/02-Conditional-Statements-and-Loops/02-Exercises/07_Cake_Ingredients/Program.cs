using System;

namespace _07_Cake_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			int counter = 0;
			while (text != "Bake!")
			{
				counter++;
				Console.WriteLine($"Adding ingredient {text}.");
				text = Console.ReadLine();
			}
			Console.WriteLine($"Preparing cake with {counter} ingredients.");
		}
	}
}
