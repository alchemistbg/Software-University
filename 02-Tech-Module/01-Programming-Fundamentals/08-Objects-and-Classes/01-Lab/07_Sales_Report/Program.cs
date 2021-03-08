using System;

namespace _07_Sales_Report
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

			for (int i = 0; i < num; i++)
			{
				string input = Console.ReadLine();
				Sale sale = new Sale().readSale(input);
				if (!salesByTown.ContainsKey(sale.Town))
				{
					salesByTown.Add(sale.Town, sale.Qty * sale.Price);
				}
				else
				{
					salesByTown[sale.Town] += sale.Qty * sale.Price;
				}
			}

			foreach (var item in salesByTown)
			{
				Console.WriteLine($"{item.Key} -> {item.Value:f2}");
			}
		}
	}

	class Sale
	{
		public string Town { get; set; }
		public string Product { get; set; }
		public decimal Price { get; set; }
		public decimal Qty { get; set; }
		public Sale()
		{

		}

		public Sale readSale(string s)
		{
			Sale sale = new Sale();
			string[] sA = s.Split(' ');
			sale.Town = sA[0];
			sale.Product = sA[1];
			sale.Price = decimal.Parse(sA[2]);
			sale.Qty = decimal.Parse(sA[3]);

			return sale;
		}
	}
}
