using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Odd_Occurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().ToLower().Split(' ').ToList().GroupBy(s => s).Select(g => new { Key = g.Key, Value = g.Count() });

			List<string> result = new List<string>();
			foreach (var item in input)
			{
				if (item.Value % 2 != 0)
				{
					result.Add(item.Key);
				}
			}

			Console.WriteLine(string.Join(", ", result));
		}
	}
}
