using System;

namespace _05_Boolean_Variable
{
	class Program
	{
		static void Main(string[] args)
		{
			Boolean boo = Convert.ToBoolean(Console.ReadLine());
			if (boo)
			{
				Console.WriteLine("Yes");
			}
			else
			{
				Console.WriteLine("No");
			}
		}
	}
}
