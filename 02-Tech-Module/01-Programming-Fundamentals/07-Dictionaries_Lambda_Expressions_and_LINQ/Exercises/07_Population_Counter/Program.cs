using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Population_Counter
{
	class Program
	{
		static Dictionary<String, long> countryPopulation = new Dictionary<string, long>();
		static Dictionary<String, Dictionary<String, long>> cityPopulation =
							new Dictionary<string, Dictionary<String, long>>();

		static void Main(string[] args)
		{
			String line = Console.ReadLine();
			while (!line.Equals("report"))
			{
				dataParser(line);
				line = Console.ReadLine();
			}
			printSortedReport();
		}

		public static void dataParser(String line)
		{
			String country = line.Split("|")[1]; ;
			String city = line.Split("|")[0];
			long cityPopulation = long.Parse(line.Split("|")[2]);
			dataFiller(country, city, cityPopulation);
		}

		public static void dataFiller(String country, String city, long pop)
		{
			if (!cityPopulation.ContainsKey(country))
			{
				cityPopulation.Add(country, new Dictionary<string, long>() {
					{city, pop}
				}
				);
			}
			else
			{
				cityPopulation[country].Add(city, pop);
			}
		}

		public static void printSortedReport()
		{
			foreach (var item in cityPopulation)
			{
				long totalPopulation = 0L;
				foreach (var item1 in item.Value)
				{
					totalPopulation += item1.Value;
				}
				countryPopulation[item.Key] = totalPopulation;
				//Console.WriteLine(totalPopulation);
			}

			var sortedCountryPopulation = from pair in countryPopulation orderby pair.Value descending select pair;
			foreach (var item in sortedCountryPopulation)
			{
				Console.WriteLine($"{item.Key} (total population: {item.Value})");
				var sortedCityPopulation = from pair in cityPopulation[item.Key] orderby pair.Value descending select pair;
				foreach (var item1 in sortedCityPopulation)
				{
					Console.WriteLine($"=>{item1.Key}: {item1.Value}");
				}
			}
		}
	}
}
