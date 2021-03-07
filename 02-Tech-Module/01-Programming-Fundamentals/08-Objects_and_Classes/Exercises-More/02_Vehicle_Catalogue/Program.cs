using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _02_Vehicle_Catalogue
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

			string input = Console.ReadLine();
			while (input != "Close the Catalogue")
			{

				if (input != "End" && input.Contains(" "))
				{

					string[] inputArr = input.Split(' ');
					Vehicle vehicle = new Vehicle();
					vehicle.Type = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputArr[0].ToLower());
					vehicle.Model = inputArr[1];
					vehicle.Color = inputArr[2];
					vehicle.HorsePower = int.Parse(inputArr[3]);
					vehicles.Add(inputArr[1], vehicle);

				}
				else if (input != "End" && !input.Contains(" "))
				{

					string query = input;
					if (vehicles.ContainsKey(query))
					{
						Console.WriteLine($"Type: {vehicles[query].Type}");
						Console.WriteLine($"Model: {vehicles[query].Model}");
						Console.WriteLine($"Color: {vehicles[query].Color}");
						Console.WriteLine($"Horsepower: {vehicles[query].HorsePower}");
					}

				}
				input = Console.ReadLine();
			}

			var cars = vehicles.Where(x => x.Value.Type == "Car");
			if (cars.Count() > 0)
			{
				Console.WriteLine($"Cars have average horsepower of: {cars.Average(x => x.Value.HorsePower):F2}.");
			}
			else
			{
				Console.WriteLine($"Cars have average horsepower of: 0.00.");

			}

			var trucks = vehicles.Where(x => x.Value.Type == "Truck");
			if (trucks.Count() > 0)
			{
				Console.WriteLine($"Trucks have average horsepower of: {trucks.Average(x => x.Value.HorsePower):F2}.");
			}
			else
			{
				Console.WriteLine($"Trucks have average horsepower of: 0.00.");
			}
		}
	}

	class Vehicle
	{
		public string Type { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int HorsePower { get; set; }
	}
}
