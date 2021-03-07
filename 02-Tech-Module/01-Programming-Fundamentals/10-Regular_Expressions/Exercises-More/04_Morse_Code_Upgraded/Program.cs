using System;
using System.Text;

namespace _04_Morse_Code_Upgraded
{
	class Program
	{
		static void Main(string[] args)
		{
			string message = Console.ReadLine();
			string[] messageArr = message.Split("|");

			StringBuilder sb = new StringBuilder();
			int sum = 0;
			foreach (string letter in messageArr)
			{
				int repeats = 1;
				for (int i = 0; i < letter.Length; i++)
				{
					if (letter[i].Equals('0'))
					{
						sum += 3;
					}

					if (letter[i].Equals('1'))
					{
						sum += 5;
					}

					if (i > 0)
					{
						if (letter[i].Equals(letter[i - 1]))
						{
							repeats++;
						}
						else
						{
							if (repeats > 1)
							{
								sum += repeats;
							}
							repeats = 1;
						}
					}
				}
				if (repeats > 1)
				{
					sum += repeats;
				}
				sb.Append(Convert.ToChar(sum));
				sum = 0;
			}

			Console.WriteLine(sb.ToString());
		}
	}
}
