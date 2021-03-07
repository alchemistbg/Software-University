using System;

namespace _01_Thea_The_Photographer
{
	class Program
	{
		static void Main(string[] args)
		{
			long numberOfPictures = long.Parse(Console.ReadLine());
			long timeToFilter = long.Parse(Console.ReadLine());
			long filterTime = numberOfPictures * timeToFilter;

			long filterFactor = long.Parse(Console.ReadLine());
			long filteredPictures = (long)Math.Ceiling((double)numberOfPictures * filterFactor / 100);

			long timeToUpload = long.Parse(Console.ReadLine());
			long uploadTime = filteredPictures * timeToUpload;

			long totalTime = filterTime + uploadTime;

			TimeSpan theaTimeSpan = new TimeSpan((long)totalTime * 10000000);
			Console.WriteLine($"{theaTimeSpan.ToString("d\\:hh\\:mm\\:ss")}");
		}
	}
}
