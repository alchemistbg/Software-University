using System;

namespace _10_Cube_Properties
{
	class Program
	{
		static void Main(string[] args)
		{
			double edge = double.Parse(Console.ReadLine());
			string parameter = Console.ReadLine();

			switch (parameter)
			{
				case "face":
					decimal faceDiag = getFaceDiag(edge);
					Console.WriteLine($"{faceDiag:f2}");
					break;
				case "space":
					decimal spaceDiag = getSpaceDiag(edge);
					Console.WriteLine($"{spaceDiag:f2}");
					break;
				case "area":
					decimal area = getArea(edge);
					Console.WriteLine($"{area:f2}");
					break;
				case "volume":
					decimal volume = getVolume(edge);
					Console.WriteLine($"{volume:f2}");
					break;
				default:
					break;
			}
		}

		static decimal getFaceDiag(double edge)
		{
			decimal faceDiag = (decimal)Math.Sqrt(2 * (Math.Pow(edge, 2)));
			return faceDiag;
		}

		static decimal getSpaceDiag(double edge)
		{
			decimal spaceDiag = (decimal)Math.Sqrt(3 * (Math.Pow(edge, 2)));
			return spaceDiag;
		}

		static decimal getArea(double edge)
		{
			decimal area = (decimal)6 * (decimal)Math.Pow(edge, 2);
			return area;
		}

		static decimal getVolume(double edge)
		{
			decimal volume = (decimal)Math.Pow(edge, 3);
			return volume;
		}
	}
}
