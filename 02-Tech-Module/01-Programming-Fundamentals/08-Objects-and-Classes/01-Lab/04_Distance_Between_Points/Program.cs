using System;
using System.Linq;

namespace _04_Distance_Between_Points
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] point1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int[] point2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			Point p1 = new Point(point1[0], point1[1]);
			Point p2 = new Point(point2[0], point2[1]);

			double distance = Point.calcDistance(p1, p2);
			Console.WriteLine($"{distance:f3}");
		}


	}

	class Point
	{
		public int x = 0;
		public int y = 0;
		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public static double calcDistance(Point p1, Point p2)
		{
			double distance = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
			return distance;
		}
	}
}
