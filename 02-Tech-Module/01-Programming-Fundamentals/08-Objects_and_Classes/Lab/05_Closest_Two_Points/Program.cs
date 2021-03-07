using System;

namespace _05_Closest_Two_Points
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			Point[] points = new Point[num];

			for (int i = 0; i < points.Length; i++)
			{
				int[] point = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
				Point p = new Point(point[0], point[1]);
				points[i] = p;
			}

			Console.WriteLine(Point.FindClosestPoints(points));
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

		public static string FindClosestPoints(Point[] points)
		{
			string result = string.Empty;
			double shortestDist = double.MaxValue;
			Point[] closestPoints = new Point[2];

			for (int i = 0; i < points.Length - 1; i++)
			{
				for (int k = i + 1; k < points.Length; k++)
				{
					double currDist = calcDistance(points[i], points[k]);

					if (shortestDist > currDist)
					{
						shortestDist = currDist;
						closestPoints[0] = new Point(points[i].x, points[i].y);
						closestPoints[1] = new Point(points[k].x, points[k].y);
					}
				}
			}

			result = $"{shortestDist:f3}\r\n(" +
				$"{closestPoints[0].x}, {closestPoints[0].y})\r\n" +
				$"({closestPoints[1].x}, {closestPoints[1].y})";
			return result;
		}
	}
}
