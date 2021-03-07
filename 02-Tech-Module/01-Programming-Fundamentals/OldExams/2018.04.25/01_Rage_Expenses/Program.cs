using System;

namespace _01_Rage_Expenses
{
	class Program
	{
		static void Main(string[] args)
		{
			int losses = int.Parse(Console.ReadLine());

			decimal headsetPrice = decimal.Parse(Console.ReadLine());
			decimal mousePrice = decimal.Parse(Console.ReadLine());
			decimal keyboardPrice = decimal.Parse(Console.ReadLine());
			decimal displayPrice = decimal.Parse(Console.ReadLine());

			decimal totalExpenses = 0.0M;

			decimal headsetExpenses = (decimal)(losses / 2 * headsetPrice);
			decimal mouseExpenses = (decimal)(losses / 3 * mousePrice);
			decimal keyboardExpenses = (decimal)(losses / (2 * 3) * keyboardPrice);
			decimal displayExpenses = (decimal)(losses / (2 * 3 * 2) * displayPrice);
			totalExpenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;
			Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
		}
	}
}
