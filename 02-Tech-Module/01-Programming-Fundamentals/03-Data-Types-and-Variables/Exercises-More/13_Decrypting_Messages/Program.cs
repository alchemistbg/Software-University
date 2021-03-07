using System;
using System.Text;

namespace _13_Decrypting_Messages
{
	class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			int num = int.Parse(Console.ReadLine());

			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < num; i++)
			{
				int codedChar = char.Parse(Console.ReadLine());
				char decodedChar = (char)(codedChar + key);
				sb.Append(decodedChar);
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
