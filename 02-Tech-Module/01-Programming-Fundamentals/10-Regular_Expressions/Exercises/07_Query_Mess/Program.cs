using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07_Query_Mess
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string inputPattern = @"(?<=\?|&|^)(?<key>[^?]+?)=(?<value>[^?]+?)(?=&|$)";
			Regex regex = new Regex(inputPattern);

			while (input != "END")
			{
				Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();
				MatchCollection mc = regex.Matches(input);
				foreach (Match match in mc)
				{
					string key = match.Groups["key"].ToString();
					string value = match.Groups["value"].ToString();

					//string fakeSpacePattern = @"(?<=^)(\+|(%20))|(\+|(%20))(?=$)";
					key = Regex.Replace(key, @"\+", " ");
					key = Regex.Replace(key, @"%20", " ");
					key = Regex.Replace(key, @"\s{2,}", " ");
					key = key.Trim();

					value = Regex.Replace(value, @"\+", " ");
					value = Regex.Replace(value, @"%20", " ");
					value = Regex.Replace(value, @"\s{2,}", " ");
					value = value.Trim();
					if (!data.ContainsKey(key))
					{
						data[key] = new List<string>();
					}
					data[key].Add(value);
				}

				foreach (var item in data)
				{
					Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
				}
				Console.WriteLine();

				input = Console.ReadLine();
			}
		}
	}
}
