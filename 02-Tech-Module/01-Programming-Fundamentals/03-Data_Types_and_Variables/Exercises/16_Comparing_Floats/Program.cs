using System;

namespace _16_Comparing_Floats
{
	class Program
	{
		static void Main(string[] args)
		{
			double d1 = double.Parse(Console.ReadLine());
			double d2 = double.Parse(Console.ReadLine());

			double eps = 0.000001;
			if (Math.Abs(d1 - d2) < eps)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
		}
	}
}
