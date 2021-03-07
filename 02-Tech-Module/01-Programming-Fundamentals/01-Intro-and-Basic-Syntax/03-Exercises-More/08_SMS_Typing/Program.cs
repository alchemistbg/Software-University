using System;

namespace _08_SMS_Typing
{
	class Program
	{
		static void Main(string[] args)
		{
			int inputNum = int.Parse(Console.ReadLine());
			string message = "";

			for (int i = 0; i < inputNum; i++)
			{
				string input = Console.ReadLine();
				message += covertInput(input);
			}
			Console.WriteLine(message);
		}

		private static char covertInput(string input)
		{
			char letter;
			if (input.Equals("0"))
			{
				letter = ' ';
			}
			else
			{
				int inputLength = input.Length;
				int mainDigit = int.Parse(input[0].ToString());
				int ofset = (mainDigit - 2) * 3;
				if (mainDigit == 8 || mainDigit == 9)
				{
					ofset++;
				}
				int letterIndex = ofset + inputLength - 1;
				letter = (char)(97 + letterIndex);
			}
			return letter;
		}
	}
}
