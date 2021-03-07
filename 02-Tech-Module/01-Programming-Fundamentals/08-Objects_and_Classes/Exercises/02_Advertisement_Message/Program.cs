using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Advertisement_Message
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(Console.ReadLine());

			string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
			string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
			string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
			string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

			List<string> messages = new List<string>();
			for (int i = 0; i < num; i++)
			{
				StringBuilder sb = new StringBuilder();
				RandomGenerator rndPhrase = new RandomGenerator(0, Phrases.Length);
				sb.Append(Phrases[rndPhrase.generate()] + " ");

				RandomGenerator rndEvent = new RandomGenerator(0, Events.Length);
				sb.Append(Events[rndEvent.generate()] + " ");

				RandomGenerator rndAuthor = new RandomGenerator(0, Authors.Length);
				sb.Append(Authors[rndAuthor.generate()]);

				RandomGenerator rndCity = new RandomGenerator(0, Cities.Length);
				sb.Append(" - " + Cities[rndCity.generate()]);

				messages.Add(sb.ToString());
			}


			foreach (var item in messages)
			{
				Console.WriteLine(item);
			}
		}
	}

	class RandomGenerator
	{
		public int min { get; set; }
		public int max { get; set; }
		public RandomGenerator(int min, int max)
		{
			this.min = min;
			this.max = max;
		}

		public int generate()
		{
			Random rnd = new Random();
			return rnd.Next(min, max);
		}
	}
}
