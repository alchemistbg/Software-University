using System;

namespace _12_Beer_Kegs
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			string biggestKegName = string.Empty;
			double biggestKegVolume = double.MinValue;

			for (int i = 0; i < num; i++)
			{
				string kegName = Console.ReadLine();
				double kegRadius = double.Parse(Console.ReadLine());
				int kegHeight = int.Parse(Console.ReadLine());
				double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

				if (biggestKegVolume < kegVolume)
				{
					biggestKegVolume = kegVolume;
					biggestKegName = kegName;
				}
			}
			Console.WriteLine(biggestKegName);
		}
	}
}
