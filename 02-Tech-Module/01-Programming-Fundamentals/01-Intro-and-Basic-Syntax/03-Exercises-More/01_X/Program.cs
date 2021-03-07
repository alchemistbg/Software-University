using System;
using System.Collections.Generic;
using System.Text;

namespace _01_X
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<string> rows = new List<string>();

			StringBuilder middle = new StringBuilder();
			middle.Append(new string(' ', n / 2));
			middle.Append("x");
			middle.Append(new string(' ', n / 2));


			StringBuilder top = new StringBuilder();
			top.Append("x");
			top.Append(new string(' ', n - 2));
			top.Append("x");
			rows.Add(top.ToString());

			StringBuilder inBetween = new StringBuilder();
			for (int i = 1; i < n / 2; i++)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(new string(' ', i));
				sb.Append("x");
				sb.Append(new string(' ', n / 2 - i));
				sb.Append(new string(' ', n / 2 - i - 1));
				sb.Append("x");
				sb.Append(new string(' ', i));
				rows.Add(sb.ToString());
			}
			rows.Add(middle.ToString());

			for (int i = 0; i < rows.Count; i++)
			{
				Console.WriteLine(rows[i]);
			}

			for (int i = rows.Count - 2; i >= 0; i--)
			{
				Console.WriteLine(rows[i]);
			}
		}
	}
}
