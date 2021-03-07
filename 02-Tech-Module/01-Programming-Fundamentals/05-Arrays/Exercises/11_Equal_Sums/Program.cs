using System;

namespace _11_Equal_Sums
{
	class Program
	{
		static void Main(string[] args)
		{
			Boolean b = false;
			int leftSum = 0;
			int rightSum = 0;

			string query = Console.ReadLine();
			int[] numArray = convertTextToNumArray(query);
			for (int i = 0; i < numArray.Length; i++)
			{
				for (int k = 0; k < i; k++)
				{
					leftSum += numArray[k];
				}
				for (int k = i + 1; k < numArray.Length; k++)
				{
					rightSum += numArray[k];
				}

				if (leftSum == rightSum)
				{
					Console.WriteLine(i);
					b = true;
				}
				leftSum = 0;
				rightSum = 0;
			}

			if (!b)
			{
				Console.WriteLine("no");
			}
		}

		static int[] convertTextToNumArray(string str)
		{
			string[] stringArray = str.Split(' ');
			int[] numArray = new int[stringArray.Length];
			for (int i = 0; i < stringArray.Length; i++)
			{
				numArray[i] = int.Parse(stringArray[i]);
			}
			return numArray;
		}
	}
}
