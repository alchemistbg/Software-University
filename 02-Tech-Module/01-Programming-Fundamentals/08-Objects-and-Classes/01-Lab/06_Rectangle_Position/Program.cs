using System;

namespace _06_Rectangle_Position
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] r1Data = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			Rectangle r1 = new Rectangle(r1Data[0], r1Data[1], r1Data[2], r1Data[3]);
			double[] r2Data = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			Rectangle r2 = new Rectangle(r2Data[0], r2Data[1], r2Data[2], r2Data[3]);

			if (Rectangle.isInside(r1, r2))
			{
				Console.WriteLine("Inside");
			}
			else
			{
				Console.WriteLine("Not inside");
			}
		}
	}

	class Rectangle
	{
		double left = 0;
		double top = 0;
		double width = 0;
		double height = 0;
		double right = 0;
		double bottom = 0;
		public Rectangle(double left, double top, double width, double height)
		{
			this.left = left;
			this.top = top;
			this.width = width;
			this.height = height;
			this.right = left + width;
			this.bottom = top + height;
		}

		public static bool isInside(Rectangle r1, Rectangle r2)
		{
			if (r1.left >= r2.left && r1.right <= r2.right && r1.top <= r2.top && r1.bottom <= r2.bottom)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
