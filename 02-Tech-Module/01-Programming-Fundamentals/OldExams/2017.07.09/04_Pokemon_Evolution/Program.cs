using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Pokemon_Evolution
{
	class Program
	{
		static List<String> evoStat = new List<string>();
		static List<String> pokemons = new List<string>();
		static void Main(string[] args)
		{
			string input = string.Empty;

			while ((input = Console.ReadLine()) != "wubbalubbadubdub")
			{
				if (input.Contains("->"))
				{
					string[] inputArr = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
					string inputToList = string.Join(";", inputArr);
					evoStat.Add(inputToList);
					if (!pokemons.Contains(inputArr[0]))
					{
						pokemons.Add(inputArr[0]);
					}
				}
				else
				{
					printOrderedByInput(input);
				}
			}

			printOrderedByIndex();
		}

		private static void printOrderedByIndex()
		{
			List<string> sl = new List<string>();
			for (int i = 0; i < pokemons.Count; i++)
			{
				Console.WriteLine($"# {pokemons[i]}");

				List<string> toPrint = evoStat.Where(x => x.Contains(pokemons[i])).ToList();

				foreach (var listItem in toPrint.OrderByDescending(x => int.Parse(x.Split(";")[2])))
				{
					Console.WriteLine($"{listItem.Split(";")[1]} <-> {listItem.Split(";")[2]}");
				}
			}

		}

		private static void printOrderedByInput(string query)
		{
			List<string> queryList = evoStat.Where(x => x.Contains(query)).ToList();
			if (queryList.Count() > 0)
			{
				Console.WriteLine($"# {query}");
				for (int i = 0; i < queryList.Count; i++)
				{
					string[] sA = queryList[i].Split(";");
					Console.WriteLine($"{sA[1]} <-> {sA[2]}");
				}
			};
		}
	}
}
