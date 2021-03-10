using System;
using System.Text.RegularExpressions;

namespace _03_Snowflake
{
	class Program
	{
		static void Main(string[] args)
		{
			string surfacePattern = @"^[^A-Za-z\d]+$";
			string mantlePattern = @"^[\d_]+$";
			string corePattern = @"^([^A-Za-z\d]+)([\d_]+)([A-Za-z]+)([\d_]+)([^A-Za-z\d]+)$";
			
			bool isValid = true;
			int coreLength = 0;
			for (int i = 0; i < 5; i++)
			{
				if (!isValid)
				{
					break;
				}
				string input = Console.ReadLine();
				switch (i)
				{
					case 0:
					case 4:
						Match mS = Regex.Match(input, surfacePattern);
						if (!mS.Success)
						{
							isValid = false;
						}
						break;
					case 1:
					case 3:
						Match mM = Regex.Match(input, mantlePattern);
						if (!mM.Success)
						{
							isValid = false;
						}
						break;
					case 2:
						Match mC = Regex.Match(input, corePattern);
						if (!mC.Success)
						{
							isValid = false;
						}
						coreLength = mC.Groups["3"].Length;
						break;
					default:
						break;
				}
			}

			if (isValid)
			{
				Console.WriteLine($"Valid\r\n{coreLength}");
			}
			else
			{
				Console.WriteLine("Invalid");
			}
		}
	}
}
