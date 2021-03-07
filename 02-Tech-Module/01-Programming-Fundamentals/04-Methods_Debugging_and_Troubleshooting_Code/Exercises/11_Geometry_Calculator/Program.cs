using System;

namespace _11_Geometry_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double area = 0.0;

			String figureType = Console.ReadLine();
			double side = 0.0;
			double height = 0.0;
			double radius = 0.0;

			switch (figureType)
			{
				case "triangle":
					side = double.Parse(Console.ReadLine());
					height = double.Parse(Console.ReadLine());
					area = getTriangleArea(side, height);
					break;
				case "square":
					side = double.Parse(Console.ReadLine());
					area = getSquareArea(side);
					break;
				case "rectangle":
					side = double.Parse(Console.ReadLine());
					height = double.Parse(Console.ReadLine());
					area = getRectArea(side, height);
					break;
				case "circle":
					radius = double.Parse(Console.ReadLine());
					area = getCircleArea(radius);
					break;
				default:
					break;
			}

			Console.WriteLine($"{area:f2}");
		}

		public static double getTriangleArea(double a, double h)
		{
			double area = a * h / 2;
			return area;
		}

		public static double getSquareArea(double a)
		{
			double area = Math.Pow(a, 2);
			return area;
		}

		public static double getRectArea(double a, double h)
		{
			double area = a * h;
			return area;
		}

		public static double getCircleArea(double r)
		{
			double area = Math.PI * Math.Pow(r, 2);
			return area;
		}
	}
}
