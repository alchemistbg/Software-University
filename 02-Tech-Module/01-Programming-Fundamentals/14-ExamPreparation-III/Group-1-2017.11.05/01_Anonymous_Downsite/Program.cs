using System;
using System.Collections.Generic;

namespace _01_Anonymous_Downsite
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> affectedSites = new List<string>();

			int inputNum = int.Parse(Console.ReadLine());
			int secKey = int.Parse(Console.ReadLine());
			double securityToken = Math.Pow(secKey, inputNum);

			decimal totalLoss = 0.0m;

			for (int i = 0; i < inputNum; i++)
			{
				string[] input = Console.ReadLine().Split(' ');
				affectedSites.Add(input[0]);

				uint visits = uint.Parse(input[1]);
				decimal pricePerVisit = decimal.Parse(input[2]);
				totalLoss += visits * pricePerVisit;
			}

			foreach (string site in affectedSites)
			{
				Console.WriteLine(site);
			}
			Console.WriteLine($"Total Loss: {totalLoss:f20}");
			Console.WriteLine($"Security Token: {securityToken:f0}");
		}
	}
}
