using System;
using System.Globalization;

namespace _04_Photo_Gallery
{
	class Program
	{
		static void Main(string[] args)
		{
			int photoNumber = int.Parse(Console.ReadLine());
			int day = int.Parse(Console.ReadLine());
			int month = int.Parse(Console.ReadLine());
			int year = int.Parse(Console.ReadLine());
			int hour = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int size = int.Parse(Console.ReadLine());
			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());

			string photoName = $"Name: DSC_{photoNumber:D4}.jpg";
			Console.WriteLine(photoName);

			DateTime dt = new DateTime(year, month, day, hour, minutes, 00);
			Console.Write("Date Taken: ");
			Console.WriteLine(dt.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture));

			string humanReadableSize = $"Size: {getReadableSize(size)}";
			Console.WriteLine(humanReadableSize);

			string aspectRatio = getAspectRation(width, height);
			Console.WriteLine($"Resolution: {width}x{height} {aspectRatio}");
		}

		private static string getAspectRation(int width, int height)
		{
			if (width > height)
			{
				return "(landscape)";
			}
			else if (width < height)
			{
				return "(portrait)";
			}
			else
			{
				return "(square)";
			}
		}

		private static string getReadableSize(int size)
		{
			string s = "";
			if (size >= 0 && size < 1000)
			{
				s = $"{size}B";
			}
			else if (size >= 1000 && size < 1000000)
			{
				s = $"{Math.Round(1.0 * size / 1000, 2)}KB";
			}
			else if (size >= 1000000 && size < 999000001)
			{
				s = $"{Math.Round(1.0 * size / 1000000, 2)}MB";
			}
			return s;
		}
	}
}
