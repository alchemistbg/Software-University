using System;

namespace _03_English_Name_Of_The_Last_Digit
{
	class Program
	{
		static void Main(string[] args)
		{
			string numberToCheck = Console.ReadLine();
			getLastDigitName(numberToCheck);
		}

		static void getLastDigitName(string numberToCheck)
		{
			char lastDigit = numberToCheck[numberToCheck.Length - 1];
			string lastDigitName = "";

			switch (lastDigit)
			{
				case '0':
					lastDigitName = "zero";
					break;
				case '1':
					lastDigitName = "one";
					break;
				case '2':
					lastDigitName = "two";
					break;
				case '3':
					lastDigitName = "three";
					break;
				case '4':
					lastDigitName = "four";
					break;
				case '5':
					lastDigitName = "five";
					break;
				case '6':
					lastDigitName = "six";
					break;
				case '7':
					lastDigitName = "seven";
					break;
				case '8':
					lastDigitName = "eight";
					break;
				case '9':
					lastDigitName = "nine";
					break;
				default:
					break;
			}
			Console.WriteLine(lastDigitName);
		}
	}
}
