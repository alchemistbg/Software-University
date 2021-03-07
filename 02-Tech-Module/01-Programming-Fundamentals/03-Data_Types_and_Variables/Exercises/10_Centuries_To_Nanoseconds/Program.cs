using System;

namespace _10_Centuries_To_Nanoseconds
{
	class Program
	{
		static void Main(string[] args)
		{
			int cent = int.Parse(Console.ReadLine());
			int years = cent * 100;
			int days = (int)(years * 365.2422);
			int hours = days * 24;
			decimal minutes = 60M * hours;
			decimal seconds = 60M * minutes;
			decimal miliseconds = 1000 * seconds;
			decimal microseconds = 1000 * miliseconds;
			decimal nanoseconds = microseconds * 1000;
			Console.WriteLine($"{cent} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
		}
	}
}
