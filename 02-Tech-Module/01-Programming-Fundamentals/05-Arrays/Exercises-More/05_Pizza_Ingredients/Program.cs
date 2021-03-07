using System;
using System.Text;

namespace _05_Pizza_Ingredients
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] ingredients = Console.ReadLine().Split(' ');
			int length = int.Parse(Console.ReadLine());

			int ingredientsCpunter = 0;
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < ingredients.Length; i++)
			{
				if (ingredients[i].Length == length)
				{
					Console.WriteLine($"Adding {ingredients[i]}.");
					ingredientsCpunter++;
					sb.Append(ingredients[i] + ", ");
				}

				if (ingredientsCpunter == 10)
				{
					break;
				}
			}
			Console.WriteLine($"Made pizza with total of {ingredientsCpunter} ingredients.");
			Console.WriteLine($"The ingredients are: {sb.ToString().TrimEnd(new char[] { ',', ' ' })}.");
		}
	}
}
