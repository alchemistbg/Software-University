using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Byte_Flip
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(" ").ToList();
			List<String> twoSymbols = new List<string>();
			foreach (String s in input)
			{
				if (s.Length == 2)
				{
					twoSymbols.Add(s);
				}
			}

			twoSymbols.Reverse();
			for (int i = 0; i < twoSymbols.Count; i++)
			{
				twoSymbols[i] = reverseString(twoSymbols[i]);
			}
			String ascii = String.Join("", twoSymbols);
			Console.WriteLine(ConvertHex(ascii));

		}

		public static string ConvertHex(String hexString)
		{
			try
			{
				string ascii = string.Empty;

				for (int i = 0; i < hexString.Length; i += 2)
				{
					String hs = string.Empty;

					hs = hexString.Substring(i, 2);
					uint decval = System.Convert.ToUInt32(hs, 16);
					char character = System.Convert.ToChar(decval);
					ascii += character;
				}

				return ascii;
			}
			catch (Exception ex) { Console.WriteLine(ex.Message); }

			return string.Empty;
		}

		public static String reverseString(String s)
		{
			char[] chArray = s.ToCharArray();
			Array.Reverse(chArray);
			return new string(chArray);
		}
	}
}
