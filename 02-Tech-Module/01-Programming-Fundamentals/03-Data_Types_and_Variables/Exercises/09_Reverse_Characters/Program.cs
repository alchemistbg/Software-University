using System;

namespace _09_Reverse_Characters
{
	class Program
	{
		static void Main(string[] args)
		{
			//char c1 = char.Parse(Console.ReadLine());
			//char c2 = char.Parse(Console.ReadLine());
			//char c3 = char.Parse(Console.ReadLine());
			String s1 = Console.ReadLine();
			String s2 = Console.ReadLine();
			String s3 = Console.ReadLine();
			Console.WriteLine(s3 + s2 + s1);
			//Console.WriteLine(concat(c1, c2, c3));
		}

		//static string concat(char c1, char c2, char c3)
		//{
		//    char[] chArray = new char[3];
		//    chArray[0] = c3;
		//    chArray[1] = c2;
		//    chArray[2] = c1;
		//    string s = new string(chArray);
		//    return s;
		//}
	}
}
