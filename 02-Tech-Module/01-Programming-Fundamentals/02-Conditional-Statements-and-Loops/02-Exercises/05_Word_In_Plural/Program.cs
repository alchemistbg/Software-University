using System;

namespace _05_Word_In_Plural
{
	class Program
	{
		static void Main(string[] args)
		{
			string noun = Console.ReadLine();

			string nounPlural = "";

			if (noun.EndsWith("y"))
			{
				nounPlural = noun.Remove(noun.LastIndexOf("y")) + "ies";
			}
			else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s") ||
					 noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
			{
				nounPlural = noun + "es";
			}
			else
			{
				nounPlural = noun + "s";
			}

			Console.WriteLine(nounPlural);
		}
	}
}
