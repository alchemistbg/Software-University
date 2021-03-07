using System;

namespace _08_Letters_Change_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

			double result = 0.0;

			for (int i = 0; i < input.Length; i++)
			{
				string s = input[i];
				string firstletter = s[0].ToString();
				string secondLetter = s[s.Length - 1].ToString();
				double number = double.Parse(s.Substring(1, s.Length - 2));
				double tempResult = 0.0;

				if (isLowerCase(firstletter))
				{
					tempResult += (number * getLetterPosition(firstletter));
				}
				else
				{
					tempResult += (number / getLetterPosition(firstletter));
				}

				if (isLowerCase(secondLetter))
				{
					tempResult = tempResult + getLetterPosition(secondLetter);
				}
				else
				{
					tempResult = tempResult - getLetterPosition(secondLetter);
				}
				result += tempResult;
			}
			Console.WriteLine($"{result:f2}");
		}

		static double getLetterPosition(string letter)
		{
			letter = letter.ToUpper();
			double position = letter[0] - 64;
			return position;
		}

		static bool isLowerCase(string letter)
		{
			bool isLower = true;
			if (letter[0] >= 64 && letter[0] <= 91)
			{
				isLower = false;
			}
			return isLower;
		}
	}
}
