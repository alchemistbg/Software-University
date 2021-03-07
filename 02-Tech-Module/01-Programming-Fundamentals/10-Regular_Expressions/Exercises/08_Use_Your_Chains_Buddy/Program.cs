using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace _08_Use_Your_Chains_Buddy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
			List<string> manual = new List<string>();
			//string input = "<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>";

			string input = Console.ReadLine();
			string tagPattern = @"(?:<p>)(?<text>.+?)(?:<\/p>)";
			Regex tagRegex = new Regex(tagPattern);
			MatchCollection mc = tagRegex.Matches(input);
			foreach (Match m in mc)
			{
				StringBuilder sb = new StringBuilder();
				sb.Append(m.Groups["text"].ToString());
				for (int i = 0; i < sb.Length; i++)
				{
					if (sb[i] > 96 && sb[i] < 110)
					{
						sb[i] = (char)((int)sb[i] + 13);
					}
					else if (sb[i] > 109 && sb[i] < 123)
					{
						sb[i] = (char)((int)sb[i] - 13);
					}
				}

				string final = Regex.Replace(sb.ToString(), @"[^a-z0-9]", " ");
				final = Regex.Replace(final, @"\s+", " ");
				manual.Add(final);
				//Console.WriteLine(sb.ToString());
			}

			Console.WriteLine(string.Join("", manual));
		}
	}
}
