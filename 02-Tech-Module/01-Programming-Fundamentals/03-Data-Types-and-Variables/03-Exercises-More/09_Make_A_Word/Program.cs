using System;
using System.Text;

namespace _09_Make_A_Word
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < num; i++)
			{
				sb.Append(Console.ReadLine());
			}

			Console.WriteLine($"The word is: {sb.ToString()}");
		}
	}
}
