﻿using System;

namespace _06_Catch_The_Thief
{
	class Program
	{
		static string max = "";

		static void Main(string[] args)
		{
			string inputType = Console.ReadLine();
			int inputNum = int.Parse(Console.ReadLine());

			string numToParse;
			for (int i = 0; i < inputNum; i++)
			{
				numToParse = Console.ReadLine();
				parseInput(inputType, numToParse);
			}
			Console.WriteLine(max);
		}

		static sbyte sbMax = sbyte.MinValue;
		static int iMax = int.MinValue;
		static long longMax = long.MinValue;
		public static void parseInput(string inputType, string numToParse)
		{
			switch (inputType)
			{
				case "sbyte":
					try
					{
						sbyte sbCurrent = checked(sbyte.Parse(numToParse));
						if (sbMax <= sbCurrent)
						{
							sbMax = sbCurrent;
							max = sbMax.ToString();
						}
					}
					catch (OverflowException)
					{

					}
					break;
				case "int":
					try
					{
						int iCurrent = checked(int.Parse(numToParse));
						if (iMax <= iCurrent)
						{
							iMax = iCurrent;
							max = iMax.ToString();
						}
					}
					catch (OverflowException)
					{

					}
					break;
				case "long":

					try
					{
						long longCurrent = checked(long.Parse(numToParse));
						if (longMax <= longCurrent)
						{
							longMax = longCurrent;
							max = longMax.ToString();
						}
					}
					catch (OverflowException)
					{

					}
					break;
				default:
					break;
			}
		}
	}
}
