using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_ForceBook
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> forceBook = new Dictionary<string, string>();
			string input = Console.ReadLine();

			while (input != "Lumpawaroo")
			{
				if (input.Contains(" | "))
				{
					string[] inputArr = input.Split(" | ");
					string userName = inputArr[1];
					string userSide = inputArr[0];

					if (!forceBook.ContainsKey(userName))
					{
						forceBook.Add(userName, userSide);
					}
				}

				if (input.Contains("->"))
				{
					string[] inputArr = input.Split(" -> ");
					string userName = inputArr[0];
					string userSide = inputArr[1];

					if (!forceBook.ContainsKey(userName))
					{
						forceBook.Add(userName, userSide);
					}
					else
					{
						forceBook[userName] = userSide;
					}

					Console.WriteLine($"{userName} joins the {userSide} side!");
				}

				input = Console.ReadLine();
			}

			var groupedDict = forceBook.GroupBy(x => x.Value);
			foreach (var group in groupedDict.OrderByDescending(x => x.Count()).ThenBy(x => x.Key))
			{
				Console.WriteLine($"Side: {group.Key}, Members: {group.Count()}");
				foreach (var user in group.OrderBy(x => x.Key))
				{
					Console.WriteLine($"! {user.Key}");
				}
			}
		}
	}
}
