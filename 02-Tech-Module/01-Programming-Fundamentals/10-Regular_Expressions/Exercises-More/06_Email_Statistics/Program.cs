using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06_Email_Statistics
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

			int n = int.Parse(Console.ReadLine());
			string emailPattern = @"^([A-Za-z]{5,})@([a-z]{3,})([.]com|[.]bg|[.]org)$";

			for (int i = 0; i < n; i++)
			{
				string email = Console.ReadLine();
				if (Regex.IsMatch(email, emailPattern))
				{
					string user = Regex.Match(email, emailPattern).Groups[1].ToString();
					string host = Regex.Match(email, emailPattern).Groups[2].ToString();
					string domain = Regex.Match(email, emailPattern).Groups[3].ToString();
					string serverName = host + domain;

					if (!dict.ContainsKey(serverName))
					{
						dict.Add(serverName, new List<string>()
						{user});
					}
					else
					{
						if (!dict[serverName].Contains(user))
						{
							dict[serverName].Add(user);
						}
					}
				}
			}

			foreach (var item in dict.OrderByDescending(x => x.Value.Count))
			{
				Console.WriteLine($"{item.Key}:");

				foreach (var item1 in item.Value)
				{
					Console.WriteLine($"### {item1.ToString()}");
				}
			}
		}
	}
}
