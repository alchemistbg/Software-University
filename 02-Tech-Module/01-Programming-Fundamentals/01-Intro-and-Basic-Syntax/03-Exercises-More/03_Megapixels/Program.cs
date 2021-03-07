using System;

namespace _03_Megapixels
{
	class Program
	{
		static void Main(string[] args)
		{
			int width = int.Parse(Console.ReadLine());
			int heigth = int.Parse(Console.ReadLine());
			double mp = Math.Round(1.0 * width * heigth / 1000000, 1);
			Console.WriteLine($"{width}x{heigth} => {mp}MP");
		}
	}
}
