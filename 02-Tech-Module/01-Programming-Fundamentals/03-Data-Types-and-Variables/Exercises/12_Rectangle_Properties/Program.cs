using System;

namespace _12_Rectangle_Properties
{
	class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			double perimeter = 2 * a + 2 * b;
			double area = a * b;
			double diagonal = Math.Sqrt(a * a + b * b);
			Console.WriteLine(perimeter);
			Console.WriteLine(area);
			Console.WriteLine(diagonal);
		}
	}
}
