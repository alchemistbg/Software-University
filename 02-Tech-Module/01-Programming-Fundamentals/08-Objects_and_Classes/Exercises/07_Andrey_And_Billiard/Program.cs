using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Andrey_And_Billiard
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

			for (int i = 0; i < num; i++)
			{
				string[] inputArr = Console.ReadLine().Split('-');
				if (!shop.ContainsKey(inputArr[0]))
				{
					shop.Add(inputArr[0], decimal.Parse(inputArr[1]));
				}
				else
				{
					shop[inputArr[0]] = decimal.Parse(inputArr[1]);
				}
			}

			List<Customer> Customers = new List<Customer>();
			while (true)
			{
				string input = Console.ReadLine();

				if (input == "end of clients")
				{
					break;
				}
				else
				{
					string[] customerInput = input.Split(new char[] { '-', ',' });
					if (shop.ContainsKey(customerInput[1]))
					{
						int cToUpdate = Customers.FindIndex(x => x.Name == customerInput[0]);
						if (cToUpdate < 0)
						{
							Customer customer = new Customer();
							customer.Name = customerInput[0];
							customer.ShopList = new Dictionary<string, int>();
							if (customer.ShopList.ContainsKey(customerInput[1]))
							{
								customer.ShopList[customerInput[1]] += int.Parse(customerInput[2]);
							}
							else
							{
								customer.ShopList.Add(customerInput[1], int.Parse(customerInput[2]));
							}
							Customers.Add(customer);
						}
						else
						{
							if (Customers[cToUpdate].ShopList.ContainsKey(customerInput[1]))
							{
								Customers[cToUpdate].ShopList[customerInput[1]] += int.Parse(customerInput[2]);
							}
							else
							{
								Customers[cToUpdate].ShopList.Add(customerInput[1], int.Parse(customerInput[2]));
							}
						}
					}
				}
			}

			foreach (var item in Customers.OrderBy(x => x.Name))
			{
				Console.WriteLine($"{item.Name}");
				foreach (var item1 in item.ShopList)
				{
					Console.WriteLine($"-- {item1.Key} - {item1.Value}");
					item.Bill += shop[item1.Key] * item1.Value;
				}
				Console.WriteLine($"Bill: {item.Bill:f2}");
			}
			Console.WriteLine($"Total bill: {Customers.Sum(x => x.Bill):f2}");
		}
	}

	class Customer
	{
		public string Name { get; set; }
		public Dictionary<string, int> ShopList { get; set; }
		public decimal Bill { get; set; }

		public Customer()
		{

		}
	}
}
