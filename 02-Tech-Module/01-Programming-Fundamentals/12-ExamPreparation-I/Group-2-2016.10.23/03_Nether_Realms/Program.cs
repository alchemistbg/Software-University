using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03_Nether_Realms
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Demon> demonList = new List<Demon>();
			string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string s in input)
			{
				string charactersPattern = @"[^+\-*\/.0-9]";
				MatchCollection mcCharacters = Regex.Matches(s, charactersPattern);
				int health = 0;
				foreach (Match m in mcCharacters)
				{
					health += (char)m.Value[0];
				}

				string numbersPattern = @"(-?)\d+(\.\d+)?";
				MatchCollection mcNumbers = Regex.Matches(s, numbersPattern);
				decimal damage = 0.0M;
				foreach (Match m in mcNumbers)
				{
					damage += decimal.Parse(m.Value);
				}

				string operatorsPattern = @"[\/|*]";
				MatchCollection mcOperators = Regex.Matches(s, operatorsPattern);
				foreach (Match m in mcOperators)
				{
					if (m.Value == "*")
					{
						damage *= 2;
					}
					else if (m.Value == "/")
					{
						damage /= 2;
					}
				}
				Demon d = new Demon();
				d.Name = s;
				d.Health = health;
				d.Damage = damage;
				demonList.Add(d);
			}

			foreach (Demon d in demonList.OrderBy(x => x.Name))
			{
				Console.WriteLine($"{d.Name} - {d.Health} health, {d.Damage:F2} damage");
			}
		}
	}

	class Demon
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public decimal Damage { get; set; }
	}
}
}
