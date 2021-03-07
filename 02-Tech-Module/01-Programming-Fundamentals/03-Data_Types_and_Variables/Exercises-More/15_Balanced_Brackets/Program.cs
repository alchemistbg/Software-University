using System;
using System.Text;

namespace _15_Balanced_Brackets
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			bool isBalanced = true;
			string prevBracket = string.Empty;

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < num; i++)
			{
				string input = Console.ReadLine();
				if (isBracket(input))
				{
					sb.Append(input);
				}
			}
			if (sb.Length % 2 != 0)
			{
				isBalanced = false;
			}
			else
			{
				for (int i = 0; i < sb.Length; i += 2)
				{
					string toCheck = sb.ToString().Substring(i, 2);
					if (!toCheck.Equals("()"))
					{
						isBalanced = false;
					}
				}
			}

			if (isBalanced)
			{
				Console.WriteLine("BALANCED");
			}
			else
			{
				Console.WriteLine("UNBALANCED");
			}
		}

		static bool isBracket(string s)
		{
			if (s.Equals("(") || s.Equals(")"))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
