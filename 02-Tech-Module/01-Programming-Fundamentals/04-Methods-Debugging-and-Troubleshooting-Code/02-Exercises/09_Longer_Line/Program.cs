using System;

namespace _09_Longer_Line
{
	class Program
	{
		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double x3 = double.Parse(Console.ReadLine());
			double y3 = double.Parse(Console.ReadLine());
			double x4 = double.Parse(Console.ReadLine());
			double y4 = double.Parse(Console.ReadLine());

			double line1 = calcLineLength(x1, y1, x2, y2);
			double line2 = calcLineLength(x3, y3, x4, y4);

			if (getLongerLine(line1, line2) == 1)
			{
				if (getClosestPoint(x1, y1, x2, y2) == 1)
				{
					Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
				}
				else
				{
					Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
				}
			}
			else
			{
				if (getClosestPoint(x3, y3, x4, y4) == 1)
				{
					Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
				}
				else
				{
					Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
				}
			}
		}

		static double calcLineLength(double x1, double y1, double x2, double y2)
		{
			double d1 = Math.Pow((x1 - x2), 2);
			double d2 = Math.Pow((y1 - y2), 2);
			double distance = Math.Sqrt(d1 + d2);
			return distance;
		}

		static int getLongerLine(double l1, double l2)
		{
			if (l1 >= l2)
			{
				return 1;
			}
			else
			{
				return 2;
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
