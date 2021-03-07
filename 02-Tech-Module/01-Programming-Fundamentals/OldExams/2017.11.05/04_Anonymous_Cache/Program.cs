using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Anonymous_Cache
{
	class Program
	{
		static List<string> dataSets = new List<string>();

		static Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
		static Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

		static void Main(string[] args)
		{
			while (true)
			{
				string input = Console.ReadLine();

				if (input == "thetinggoesskrra")
				{
					break;
				}
				else
				{
					parseInput(input);
				}
			}

			processFinalData();
		}

		private static void processFinalData()
		{
			if (data.Count > 0)
			{
				Dictionary<string, long> sizes = new Dictionary<string, long>();

				foreach (var item1 in data)
				{

					long totalSize = 0;
					foreach (var item2 in item1.Value)
					{
						totalSize += item2.Value;
					}
					sizes.Add(item1.Key, totalSize);

				}

				string maxDataSet = sizes.OrderByDescending(x => x.Value).First().Key;
				long maxDataSize = sizes.OrderByDescending(x => x.Value).First().Value;

				Console.WriteLine($"Data Set: {maxDataSet}, Total Size: {maxDataSize}");

				foreach (var item in data[maxDataSet])
				{
					Console.WriteLine($"$.{item.Key}");
				}
			}
		}

		static void parseInput(string input)
		{
			string[] inputArr = input.Split(' ');

			if (inputArr.Length == 1)
			{
				dataSets.Add(inputArr[0]);
				if (cache.ContainsKey(inputArr[0]))
				{
					cache.ToList().ForEach(x => data.Add(x.Key, x.Value));
				}
			}
			else
			{
				string dataKey = inputArr[0];
				long dataSize = long.Parse(inputArr[2]);
				string dataset = inputArr[4];

				if (dataSets.Contains(dataset))
				{
					if (data.ContainsKey(dataset))
					{
						data[dataset].Add(dataKey, dataSize);
					}
					else if (!data.ContainsKey(dataset))
					{
						data.Add(dataset, new Dictionary<string, long>()
							{
								{dataKey, dataSize}
							}
						);

					}
				}
				else
				{
					if (cache.ContainsKey(dataset))
					{
						cache[dataset].Add(dataKey, dataSize);
					}
					else if (!cache.ContainsKey(dataset))
					{
						cache.Add(dataset, new Dictionary<string, long>()
							{
								{dataKey, dataSize}
							}
						);

					}
				}

			}
		}
	}
}
