using System;
using System.Linq;

namespace _05_Short_Words_Sorted
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().Where(x => x.Length < 5).ToList().OrderBy(x => x);
			Console.WriteLine(string.Join(", ", input));
		}
	}
}
