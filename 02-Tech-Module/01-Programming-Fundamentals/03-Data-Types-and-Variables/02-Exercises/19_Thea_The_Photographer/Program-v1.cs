using System;

namespace _19_Thea_The_Photographer
{
	class Program
	{
		static void Main(string[] args)
		{
			long totalPicturesNumber = long.Parse(Console.ReadLine());
			long filterTime = long.Parse(Console.ReadLine());
			long timeToFilter = totalPicturesNumber * filterTime;

			long filterFactor = long.Parse(Console.ReadLine());
			double goodPicturesNumber = Math.Ceiling(1.0 * totalPicturesNumber * filterFactor / 100);

			long uploadTime = long.Parse(Console.ReadLine());

			long timeToUpload = (long)goodPicturesNumber * uploadTime;

			long totalTime = timeToFilter + timeToUpload;

			TimeSpan ts = new TimeSpan(totalTime * 10000000);
			Console.WriteLine($"{ts.Days}:{ts.Hours.ToString("00")}:{ts.Minutes.ToString("00")}:{ts.Seconds.ToString("00")}");
		}
	}
}
