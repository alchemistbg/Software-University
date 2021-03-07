using System;
using System.Text.RegularExpressions;

namespace _03_SoftUni_Bar_Income
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			decimal totalIncome = 0.0M;
			while (input != "end of shift")
			{
				string pattern = @"^[^\|\$\%\.]*%(?<name>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<qty>\d+)\|[^\|\$\%\.\d]*(?<price>\d+\.{0,1}\d*\$)";
				MatchCollection mc = Regex.Matches(input, pattern);

				foreach (Match item in mc)
				{
					string name = item.Groups["name"].ToString();
					string product = item.Groups["product"].ToString();
					long qty = long.Parse(item.Groups["qty"].ToString());
					decimal price = decimal.Parse(item.Groups["price"].ToString().Replace("$", ""));
					decimal currentIncome = price * qty;
					totalIncome += currentIncome;

					Console.WriteLine($"{name}: {product} - {currentIncome:F2}");
				}

				input = Console.ReadLine();
			}
			Console.WriteLine($"Total income: {totalIncome:F2}");
		}
	}
}
