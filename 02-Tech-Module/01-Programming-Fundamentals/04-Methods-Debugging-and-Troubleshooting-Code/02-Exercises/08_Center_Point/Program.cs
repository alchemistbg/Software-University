using System;

namespace _08_Center_Point
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());

			if (getClosestPoint(x1, y1, x2, y2) == 1)
			{
				Console.WriteLine($"({x1}, {y1})");
			}
			else
			{
				Console.WriteLine($"({x2}, {y2})");
			}
		}

		static int getClosestPoint(double x1, double y1, double x2, double y2)
		{
			double d1 = Math.Pow((x1 - 0), 2);
			double d2 = Math.Pow((y1 - 0), 2);
			double distance1 = Math.Sqrt(d1 + d2);

			double d3 = Math.Pow((x2 - 0), 2);
			double d4 = Math.Pow((y2 - 0), 2);
			double distance2 = Math.Sqrt(d3 + d4);

			if (distance1 <= distance2)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}
	}
}
