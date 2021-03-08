using System;
using System.Linq;

namespace _03_Intersection_Of_Circles
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] c1A = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			Circle c1 = new Circle(c1A[0], c1A[1], c1A[2]);

			double[] c2A = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			Circle c2 = new Circle(c2A[0], c2A[1], c2A[2]);

			string result = string.Empty;
			if (Circle.Intersect(c1, c2))
			{
				result = "Yes";
			}
			else
			{
				result = "No";
			}

			Console.WriteLine(result);
		}
	}

	class Circle
	{
		public double radius { get; set; }
		public Point center;

		public Circle(double x, double y, double radius)
		{
			center = new Point(x, y);
			this.radius = radius;
		}

		public static bool Intersect(Circle c1, Circle c2)
		{
			bool b = false;
			double dist = Point.calcPointsDistance(c1.center, c2.center);
			if (dist <= c1.radius + c2.radius)
			{
				b = true;
			}
			return b;
		}
	}

	class Point
	{
		public double x { get; set; }
		public double y { get; set; }

		public Point(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		public static double calcPointsDistance(Point p1, Point p2)
		{
			double distance = 0.0;
			distance = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
			return distance;
		}
	}
}
