using System;

namespace _06_Strings_And_Objects
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = Console.ReadLine();
			string s2 = Console.ReadLine();
			Object o = s1 + " " + s2;
			string s3 = (string)o;
			Console.WriteLine(s3);
		}
	}
}
