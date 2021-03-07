using System;

namespace _18_Different_Integers_Size
{
	class Program
	{
		static void Main(string[] args)
		{
			string number = Console.ReadLine();

			string message = "";
			try
			{
				sbyte sb = sbyte.Parse(number);
				message += "* sbyte\r\n";
			}
			catch (Exception)
			{

			}

			try
			{
				byte b = byte.Parse(number);
				message += "* byte\r\n";
			}
			catch (Exception)
			{

			}

			try
			{
				short s = short.Parse(number);
				message += "* short\r\n";
			}
			catch (Exception)
			{

			}

			try
			{
				ushort us = ushort.Parse(number);
				message += "* ushort\r\n";
			}
			catch (Exception)
			{

			}

			try
			{
				int i = int.Parse(number);
				message += "* int\r\n";
			}
			catch (Exception)
			{

			}

			try
			{
				uint ui = uint.Parse(number);
				message += "* uint\r\n";
			}
			catch (Exception)
			{

			}

			try
			{
				long l = long.Parse(number);
				message += "* long\r\n";
			}
			catch (Exception)
			{

			}

			if (message.Length == 0)
			{
				Console.WriteLine($"{number} can't fit in any type");
			}
			else
			{
				Console.WriteLine($"{number} can fit in:");
				Console.WriteLine(message);
			}
		}
	}
}
