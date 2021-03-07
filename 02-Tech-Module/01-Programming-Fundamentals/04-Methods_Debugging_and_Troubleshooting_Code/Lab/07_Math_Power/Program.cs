using System;

namespace _07_Math_Power
{
	class Program
	{
		static void Main(string[] args)
		{
			double num = double.Parse(Console.ReadLine());
			double power = double.Parse(Console.ReadLine());

			double result = calcPower(num, power);

			Console.WriteLine(result);
		}

		private static double calcPower(double num, double power)
		{
			return Math.Pow(num, power);
		}
	}
}
