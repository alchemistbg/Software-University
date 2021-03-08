using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05_Parking_Validation
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> parkingDB = new Dictionary<string, string>();

			int num = int.Parse(Console.ReadLine());

			for (int i = 0; i < num; i++)
			{
				string[] input = Console.ReadLine().Split();

				if (input[0].Equals("register"))
				{
					string userName = input[1];
					string licensePlate = input[2];

					if (parkingDB.ContainsKey(userName))
					{
						Console.WriteLine($"ERROR: already registered with plate number {parkingDB[userName]}");
					}
					else if (parkingDB.ContainsValue(licensePlate))
					{
						Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
					}
					else if (!isValid(licensePlate))
					{
						Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
					}
					else
					{
						parkingDB.Add(userName, licensePlate);
						Console.WriteLine($"{userName} registered {licensePlate} successfully");
					}
				}
				else
				{
					string userName = input[1];
					if (!parkingDB.ContainsKey(userName))
					{
						Console.WriteLine($"ERROR: user {userName} not found");
					}
					else
					{
						parkingDB.Remove(userName);
						Console.WriteLine($"user {userName} unregistered successfully");
					}
				}

			}

			foreach (var item in parkingDB)
			{
				Console.WriteLine($"{item.Key} => {item.Value}");
			}

		}

		static bool isValid(string s)
		{
			bool b = true;
			string platePattern = @"[A-Z]{2}[0-9]{4}[A-Z]{2}";
			if (!Regex.IsMatch(s, platePattern))
			{
				b = false;
			}
			return b;
		}
	}
}
