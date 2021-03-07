using System;
using System.Text;

namespace _04_Draw_A_Filled_Square
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());
			printLine(num);

			for (int i = 0; i < num - 2; i++)
			{
				printMiddle(num);
			}
			printLine(num);
		}

		private static void printMiddle(int num)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("-");

			for (int i = 0; i < 2 * num - 2; i++)
			{
				if ((i % 2) == 0)
				{
					sb.Append(@"\");
				}
				else
				{
					sb.Append("/");
				}
			}

			sb.Append("-");

			Console.WriteLine(sb.ToString());
		}

		private static void printLine(int num)
		{
			string line = new string('-', 2 * num);
			Console.WriteLine(line);
		}
	}
}
