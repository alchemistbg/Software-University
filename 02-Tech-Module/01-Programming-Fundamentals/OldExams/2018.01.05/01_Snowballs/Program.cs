using System;
using System.Numerics;

namespace _01_Snowballs
{
	class Program
	{
		static void Main(string[] args)
		{
			int ballNum = int.Parse(Console.ReadLine());

			BigInteger maxSnowballSnow = 0;
			BigInteger maxSnowballTime = 0;
			BigInteger maxSnowballQuality = 0;
			BigInteger maxSnowballValue = 0;
			for (int i = 0; i < ballNum; i++)
			{
				int snowballSnow = int.Parse(Console.ReadLine());
				int snowballTime = int.Parse(Console.ReadLine());
				int snowballQuality = int.Parse(Console.ReadLine());

				BigInteger snowballValue = (BigInteger)BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
				if (snowballValue > maxSnowballValue)
				{
					maxSnowballValue = snowballValue;
					maxSnowballSnow = snowballSnow;
					maxSnowballTime = snowballTime;
					maxSnowballQuality = snowballQuality;
				}
			}
			Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxSnowballValue} ({maxSnowballQuality})");
		}
	}
}
