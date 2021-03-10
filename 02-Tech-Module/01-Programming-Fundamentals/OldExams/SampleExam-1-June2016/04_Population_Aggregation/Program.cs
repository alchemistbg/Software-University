using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_Population_Aggregation
{
	class Program
	{
		static void Main(string[] args)
		{
			string test = "test";
			Dictionary<string, int> countries = new Dictionary<string, int>();
			Dictionary<string, long> cities = new Dictionary<string, long>();
			string input = Console.ReadLine();
			while (input != "stop")
			{
				string[] inputArr = input.Split('\\');
				string pattern = @"[@#$&\d]";
				string string0 = Regex.Replace(inputArr[0], pattern, "");
				string string1 = Regex.Replace(inputArr[1], pattern, "");

				string country = string.Empty;
				string city = string.Empty;
				//if (char.IsUpper(string0[0]))
				if (Regex.IsMatch(string0, @"^[A-Z]") && Regex.IsMatch(string1, @"^[a-z]"))
				{
					country = string0;
					city = string1;
				}
				else
				{
					country = string1;
					city = string0;
				}
				long population = long.Parse(inputArr[2]);

				if (!countries.ContainsKey(country))
				{
					countries[country] = 1;
				}
				else
				{
					countries[country]++;
				}

				cities[city] = population;

				input = Console.ReadLine();
			}

			foreach (var country in countries.OrderBy(x => x.Key))
			{
				Console.WriteLine($"{country.Key} -> {country.Value}");
			}

			foreach (var city in cities.OrderByDescending(x => x.Value).Take(3))
			{
				Console.WriteLine($"{city.Key} -> {city.Value}");
			}
		}
	}
}
