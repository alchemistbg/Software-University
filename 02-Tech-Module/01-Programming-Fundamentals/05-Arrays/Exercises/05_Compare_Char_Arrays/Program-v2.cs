using System;

namespace _05_Compare_Char_Arrays
{
	class Program_v2
	{
		static void Main(string[] args)
		{
			string query1 = "c d"; //Console.ReadLine();
			string query2 = "a b"; //Console.ReadLine();
			char[] charArray1 = convertTextToCharArray(query1);
			char[] charArray2 = convertTextToCharArray(query2);

			Boolean chArr1 = false;
			Boolean chArr2 = false;

			if (charArray1.Length > charArray2.Length)
			{
				for (int i = 0; i < charArray2.Length; i++)
				{
					for (int k = 0; k < charArray1.Length; k++)
					{
						if (charArray2[i] <= charArray1[k])
						{
							chArr2 = true;
							//break;
						}
						else
						{
							chArr1 = true;
							//break;
						}
					}
					//break;
				}
			}
			else
			{
				for (int i = 0; i < charArray1.Length; i++)
				{
					for (int k = 0; k < charArray2.Length; k++)
					{
						if (charArray1[i] < charArray2[k])
						{
							chArr1 = true;
							//break;
						}
						else
						{
							chArr2 = true;
							//break;
						}
					}
					//break;
				}
			}

			if (chArr1)
			{
				string s1 = string.Join("", charArray1);
				Console.WriteLine(s1);
				string s2 = string.Join("", charArray2);
				Console.WriteLine(s2);
			}
			else
			{
				string s2 = string.Join("", charArray2);
				Console.WriteLine(s2);
				string s1 = string.Join("", charArray1);
				Console.WriteLine(s1);
			}
		}

		static char[] convertTextToCharArray(string str)
		{
			string[] stringArray = str.Split(' ');
			char[] numArray = new char[stringArray.Length];
			for (int i = 0; i < stringArray.Length; i++)
			{
				numArray[i] = char.Parse(stringArray[i]);
			}
			return numArray;
		}
	}
}
