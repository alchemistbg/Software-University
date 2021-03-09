using System;
using System.Text.RegularExpressions;

namespace _06_Replace_a_Tag
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "end")
			{
				string pattern = @"(?<tagStart><a href="")(?<url>.+)(?<tagEnd>"">)(?<linkTitle>.+)(?<tagClose><\/a>)";
				string substitution = @"[URL href=""${url}""]${linkTitle}[/URL]";

				RegexOptions options = RegexOptions.Multiline;
				Regex regex = new Regex(pattern, options);

				string result = regex.Replace(input, substitution);
				Console.WriteLine(result);

				input = Console.ReadLine();
			}
		}

		//static void Main(string[] args)
		//{
		//	string input = string.Empty;
		//	string patternStart = @"<a href";
		//	string patternMiddle = "\">";
		//	string patternEnd = @"</a>";

		//	while ((input = Console.ReadLine()) != "end")
		//	{
		//		string newStart = "[URL href";
		//		Regex regexStart = new Regex(patternStart);
		//		input = regexStart.Replace(input, newStart);
		//		string newMiddle = "\"]";
		//		Regex regexMiddle = new Regex(patternMiddle);
		//		input = regexMiddle.Replace(input, newMiddle);
		//		string newEnd = "[/URL]";
		//		Regex regexEnd = new Regex(patternEnd);
		//		input = regexEnd.Replace(input, newEnd);

		//		Console.WriteLine(input);
		//	}
		//}
	}
}
