using System;
using System.Text;

namespace _03_Printing_Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			for (int i = 1; i <= num; i++)
			{
				printLine(1, i);
			}

			for (int i = num - 1; i >= 1; i--)
			{
				printLine(1, i);
			}
		}

		static void printLine(int start, int end)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = start; i <= end; i++)
			{
				sb.Append(i + " ");
			}
			Console.WriteLine(sb.ToString().Trim());
		}
	}
}
