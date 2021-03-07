using System;

namespace _08_House_Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			string input1 = Console.ReadLine();
			string input2 = Console.ReadLine();

			sbyte sbytePrice = 0;
			int intPrice = 0;

			try
			{
				sbytePrice = sbyte.Parse(input1);
				intPrice = int.Parse(input2);
			}
			catch (OverflowException e)
			{
				sbytePrice = sbyte.Parse(input2);
				intPrice = int.Parse(input1);
			}

			long totalPrice = (long)(4l * sbytePrice) + (long)(10l * intPrice);
			Console.WriteLine(totalPrice);
		}
	}
}
