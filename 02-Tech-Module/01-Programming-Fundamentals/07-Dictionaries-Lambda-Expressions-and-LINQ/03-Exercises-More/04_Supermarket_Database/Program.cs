using System;
using System.Collections.Generic;

namespace _04_Supermarket_Database
{
	class Program
	{
		static Dictionary<String, decimal> priceDB = new Dictionary<String, decimal>();
		static Dictionary<String, int> qtyDB = new Dictionary<String, int>();

		static void Main(string[] args)
		{

			String input = Console.ReadLine();
			while (!input.Equals("stocked"))
			{
				String[] inputArr = input.Split(" ");
				String productName = inputArr[0];
				decimal productPrice = decimal.Parse(inputArr[1]);
				int productQty = int.Parse(inputArr[2]);
				proccessInput(productName, productPrice, productQty);
				input = Console.ReadLine();
			}
			decimal grandTotal = 0.0M;
			foreach (var item in priceDB)
			{
				decimal currentProductTotal = item.Value * qtyDB[item.Key];
				Console.WriteLine($"{item.Key}: ${item.Value} * {qtyDB[item.Key]} = ${currentProductTotal}");
				grandTotal += currentProductTotal;
			}
			Console.WriteLine($"------------------------------\r\nGrand Total: ${grandTotal}");
		}

		private static void proccessInput(string productName, decimal productPrice, int productQty)
		{
			if (!priceDB.ContainsKey(productName))
			{
				priceDB.Add(productName, productPrice);
				qtyDB.Add(productName, productQty);
			}
			else
			{
				priceDB[productName] = productPrice;
				qtyDB[productName] += productQty;
			}
		}
	}
}
