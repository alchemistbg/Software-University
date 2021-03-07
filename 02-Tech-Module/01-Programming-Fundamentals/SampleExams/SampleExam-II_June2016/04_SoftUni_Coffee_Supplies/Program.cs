using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_SoftUni_Coffee_Supplies
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> Persons = new Dictionary<string, string>();
			Dictionary<string, long> Coffies = new Dictionary<string, long>();

			List<string> personInput = new List<string>();
			List<string> coffeeInput = new List<string>();

			string[] delimiters = Console.ReadLine().Split(' ');
			string delimiter0 = delimiters[0];
			string delimiter1 = delimiters[1];

			string infoInput = Console.ReadLine();
			while (infoInput != "end of info")
			{
				if (infoInput.Contains(delimiter0))
				{
					personInput.Add(infoInput);
				}
				else if (infoInput.Contains(delimiter1))
				{
					coffeeInput.Add(infoInput);
				}
				infoInput = Console.ReadLine();
			}

			foreach (string s in coffeeInput)
			{
				string[] infoArr = Regex.Split(s, Regex.Escape(delimiter1));
				if (!Coffies.ContainsKey(infoArr[0]))
				{
					Coffies[infoArr[0]] = int.Parse(infoArr[1]);
				}
				else
				{
					Coffies[infoArr[0]] += int.Parse(infoArr[1]);
				}
			}

			foreach (string s in personInput)
			{
				string[] infoArr = Regex.Split(s, Regex.Escape(delimiter0));// s.Split(delimiter0);
				if (Coffies.ContainsKey(infoArr[1]))
				{
					Persons[infoArr[0]] = infoArr[1];
				}
				else
				{
					Console.WriteLine($"Out of {infoArr[1]}");
				}

			}

			string ordersInput = Console.ReadLine();
			while (ordersInput != "end of week")
			{
				string[] orderArr = ordersInput.Split(' ');
				string person = orderArr[0];
				long qty = long.Parse(orderArr[1]);

				string personOrder = Persons[person];
				if (Coffies.ContainsKey(personOrder))
				{
					Coffies[personOrder] -= qty;
					if (Coffies[personOrder] <= 0)
					{
						Console.WriteLine($"Out of {personOrder}");
						Coffies.Remove(personOrder);
					}
				}
				else
				{
					Console.WriteLine($"Out of {personOrder}");
				}
				ordersInput = Console.ReadLine();
			}

			Console.WriteLine("Coffee Left:");
			foreach (var Coffee in Coffies.OrderByDescending(x => x.Value))
			{
				Console.WriteLine($"{Coffee.Key} {Coffee.Value}");
			}

			Console.WriteLine("For:");
			foreach (var Person in Persons.Where(x => Coffies.Keys.Contains(x.Value)).OrderBy(x => x.Value).ThenByDescending(x => x.Key))
			{
				Console.WriteLine($"{Person.Key} {Person.Value}");
			}
		}
	}
}
