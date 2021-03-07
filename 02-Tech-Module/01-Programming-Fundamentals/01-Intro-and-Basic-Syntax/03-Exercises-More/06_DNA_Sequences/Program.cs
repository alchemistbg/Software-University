using System;
using System.Text;

namespace _06_DNA_Sequences
{
	class Program
	{
		static void Main(string[] args)
		{
			int matchSum = int.Parse(Console.ReadLine());

			string[] bases = { "A", "C", "G", "T" };

			int counter = 0;

			for (int i = 0; i < bases.Length; i++)
			{
				for (int j = 0; j < bases.Length; j++)
				{
					for (int k = 0; k < bases.Length; k++)
					{
						counter++;
						int numValue = i + j + k + 3;

						StringBuilder middle = new StringBuilder();
						middle.Append(bases[i]);
						middle.Append(bases[j]);
						middle.Append(bases[k]);

						StringBuilder seq = new StringBuilder();

						if (numValue >= matchSum)
						{

							seq.Append("O");
							seq.Append(middle.ToString());
							seq.Append("O");
						}
						else
						{
							seq.Append("X");
							seq.Append(middle.ToString());
							seq.Append("X");
						}

						if (counter % 4 == 0)
						{
							seq.Append("\n");

						}
						else
						{
							seq.Append(" ");
						}
						Console.Write(seq.ToString());
					}
				}
			}
		}
	}
}
