using System;

namespace _11_5_Different_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			if (b - a < 5)
			{
				Console.WriteLine("No");
			}
			else
			{
				int i1 = a;
				int i2 = a + 1;
				int i3 = a + 2;
				int i4 = a + 3;
				int i5 = a + 4;
				//Console.WriteLine($"{i1} {i2} {i3} {i4} {i5}");

				for (int i = a; i <= b; i++)
				{
					for (int j = a; j <= b; j++)
					{
						for (int k = a; k <= b; k++)
						{
							for (int l = a; l <= b; l++)
							{
								for (int m = a; m <= b; m++)
								{
									if (i < j && j < k && k < l && l < m)
									{
										Console.WriteLine(i + " " + j + " " + k + " " + l + " " + m);
									}
								}
							}
						}
					}
				}

			}
		}
	}
}
