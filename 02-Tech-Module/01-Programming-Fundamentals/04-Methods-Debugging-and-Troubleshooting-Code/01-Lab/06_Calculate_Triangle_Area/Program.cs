using System;

namespace _06_Calculate_Triangle_Area
{
	class Program
	{
		static void Main(string[] args)
		{
			double triangleBase = double.Parse(Console.ReadLine());
			double triangleHeigth = double.Parse(Console.ReadLine());

			double triangleArea = calcTriangleArea(triangleBase, triangleHeigth);

			Console.WriteLine($"{triangleArea}");
		}

		private static double calcTriangleArea(double triangleBase, double triangleHeigth)
		{
			double area = 0.0;
			area = triangleBase * triangleHeigth / 2;
			return area;
		}
	}
}
