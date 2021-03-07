using System;
using System.Text;

namespace _11_String_Concatenation
{
	class Program
	{
		static void Main(string[] args)
		{
			string joinSymbol = Console.ReadLine();
			string evenOrOdd = Console.ReadLine();
			int num = int.Parse(Console.ReadLine());
			
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < num; i++)
			{
				string input = Console.ReadLine();
				int currNumber = i + 1;

				if (currNumber % 2 == 0)
				{
					if (evenOrOdd.Equals("even"))
					{
						sb.Append(input);
						sb.Append(joinSymbol);
					}
				}
				else
				{
					if (evenOrOdd.Equals("odd"))
					{
						sb.Append(input);
						sb.Append(joinSymbol);
					}
				}
			}

			Console.WriteLine(sb.ToString().Remove(sb.ToString().Length - 1));
		}
	}
}
