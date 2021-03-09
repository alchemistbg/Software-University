using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_Weather
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Forecast> weather = new Dictionary<string, Forecast>();

			string input = string.Empty;
			string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>\w*[^\d\|])\|";

			while ((input = Console.ReadLine()) != "end")
			{
				if (Regex.IsMatch(input, pattern))
				{
					string city = Regex.Match(input, pattern).Groups["city"].ToString();
					double temp = double.Parse(Regex.Match(input, pattern).Groups["temp"].ToString());
					string weatherType = Regex.Match(input, pattern).Groups["weather"].ToString();

					Forecast fC = new Forecast();
					fC.City = city;
					fC.Temp = temp;
					fC.Weather = weatherType;
					weather[city] = fC;
				}
			}

			foreach (var fCast in weather.OrderBy(x => x.Value.Temp))
			{
				Console.WriteLine($"{fCast.Value.City} => {fCast.Value.Temp:f2} => {fCast.Value.Weather }");
			}

		}
	}

	class Forecast
	{
		public string City { get; set; }
		public double Temp { get; set; }
		public string Weather { get; set; }
	}
}
