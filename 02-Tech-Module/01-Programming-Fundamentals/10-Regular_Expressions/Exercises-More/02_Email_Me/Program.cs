using System;

namespace _02_Email_Me
{
	class Program
	{
		static void Main(string[] args)
		{
			string email = Console.ReadLine();
			string[] emailArr = email.Split("@");
			string preffix = emailArr[0];
			int sumPreffix = 0;
			foreach (char ch in preffix)
			{
				sumPreffix += ch;
			}

			string suffix = emailArr[1];
			int sumSuffix = 0;
			foreach (char ch in suffix)
			{
				sumSuffix += ch;
			}

			int diff = sumPreffix - sumSuffix;

			if (diff >= 0)
			{
				Console.WriteLine("Call her!");
			}
			else
			{
				Console.WriteLine("She is not the one.");
			}
		}
	}
}
