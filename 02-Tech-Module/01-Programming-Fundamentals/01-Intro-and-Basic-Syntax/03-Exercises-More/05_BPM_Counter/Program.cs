using System;

namespace _05_BPM_Counter
{
	class Program
	{
		static void Main(string[] args)
		{
			int bpm = int.Parse(Console.ReadLine());
			int beats = int.Parse(Console.ReadLine());

			double bars = Math.Round(1.0 * beats / 4, 1);
			Console.WriteLine($"{bars} bars - {calcTime(bpm, beats)}");
		}

		private static string calcTime(int bpm, int beats)
		{
			string time = "";
			double beatPerSecond = 1.0 * 60 / bpm;
			double totalSeconds = 1.0 * beatPerSecond * beats;
			int min = (int)totalSeconds / 60;
			int sec = (int)totalSeconds % 60;
			time = $"{min}m {sec}s";
			return time;
		}
	}
}
