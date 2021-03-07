using System;

namespace _05_Key_Replacer
{
	class Program
	{
		static void Main(string[] args)
		{
			string key = Console.ReadLine();

			string keyPattern = @"^(?<start>[A-Za-z]+)(?<sepS>\||\<|\\)(?:\w+)(?<sepE>\||\<|\\)(?<end>[A-Za-z]+)$";
			Regex regex = new Regex(keyPattern);
			Match match = regex.Match(key);
			string start = match.Groups["start"].Value;
			string end = match.Groups["end"].Value;

			string text = Console.ReadLine();

			string textPattern = $@"{start}(?<word>\w*?){end}";
			Regex regex2 = new Regex(textPattern);
			MatchCollection mc = regex2.Matches(text);
			List<string> message = new List<string>();
			foreach (Match item in mc)
			{
				message.Add(item.Groups["word"].ToString());
			}
			if (message.Count > 0)
			{

				Console.WriteLine(string.Join("", message));
			}
			else
			{
				Console.WriteLine("Empty result");
			}
		}
	}
}
