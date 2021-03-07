﻿using System;

namespace _08_Refactor_Volume_Of_Pyramid
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Length: ");
			double length = double.Parse(Console.ReadLine());
			Console.Write("Width: ");
			double width = double.Parse(Console.ReadLine());
			Console.Write("Height: ");
			double heigth = double.Parse(Console.ReadLine());

			double volume = (length * width * heigth) / 3;
			Console.Write($"Pyramid Volume: {volume:F2}");
		}
	}
}
