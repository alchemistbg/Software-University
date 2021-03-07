using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Beer_Kegs
{
	class Program_v2
	{
		class Keg
		{
			public string Name { get; set; }
			public double Radius { get; set; }
			public int Height { get; set; }
			public double Volume { get { return Math.PI * Math.Pow(Radius, 2) * Height; } }
		}

		class Program
		{

			//static void Main(string[] args)
			//{
			//	int num = int.Parse(Console.ReadLine());

			//	List<Keg> kegs = new List<Keg>();
			//	for (int i = 0; i < num; i++)
			//	{
			//		Keg keg = new Keg();
			//		keg.Name = Console.ReadLine();
			//		keg.Radius = double.Parse(Console.ReadLine());
			//		keg.Height = int.Parse(Console.ReadLine());
			//		kegs.Add(keg);
			//	}

			//	Console.WriteLine(kegs.OrderByDescending(x => x.Volume).ElementAt(0).Name);
			//}
		}
	}
}
