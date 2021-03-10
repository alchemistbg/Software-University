using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Snowwhite
{
	class Program_v04
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dwarf> Dwarfs = new Dictionary<string, Dwarf>();
			string input = Console.ReadLine();

			while (input != "Once upon a time")
			{
				string[] inputArr = input.Split(new char[] { ' ', ':', '<', '>' }, StringSplitOptions.RemoveEmptyEntries);

				string dName = inputArr[0];
				string dHat = inputArr[1];
				long dPhysyics = long.Parse(inputArr[2]);
				string dKey = dName + ";" + dHat;

				if (!Dwarfs.ContainsKey(dKey))
				{
					Dwarfs[dKey] = new Dwarf();
				}

				if (Dwarfs[dKey].Physics < dPhysyics)
				{
					Dwarfs[dKey].Physics = dPhysyics;
				}

				Dwarfs[dKey].Name = dName;
				Dwarfs[dKey].HatColor = dHat;

				input = Console.ReadLine();
			}

			var orderedList = Dwarfs.OrderByDescending(x => x.Value.Physics).ThenByDescending(x => Dwarfs.Count(y => y.Value.HatColor == x.Value.HatColor));
			foreach (var dwarf in orderedList)
			{
				Console.WriteLine($"({dwarf.Value.HatColor}) {dwarf.Value.Name} <-> {dwarf.Value.Physics}");
			}
		}
	}

	class Dwarf
	{
		public string Name { get; set; }
		public string HatColor { get; set; }
		public long Physics { get; set; }
	}
}
