using System;
using System.Text.RegularExpressions;

namespace _04_Winning_Ticket
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

			foreach (string ticket in tickets)
			{
				if (ticket.Length != 20)
				{
					Console.WriteLine("invalid ticket");
				}
				else
				{
					string pattern = @"@{6,10}|#{6,10}|\${6,10}|\^{6,10}";
					string left = ticket.Substring(0, 10);
					Match leftMatch = Regex.Match(left, pattern);
					string right = ticket.Substring(10);
					Match rightMatch = Regex.Match(right, pattern);
					if (leftMatch.ToString().Length > 0 && rightMatch.ToString().Length > 0)
					{
						if (leftMatch.ToString().Length < 10 || rightMatch.ToString().Length < 10)
						{
							Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftMatch.ToString().Length, rightMatch.ToString().Length)}{leftMatch.ToString()[0]}");
						}
						else
						{
							Console.WriteLine($"ticket \"{ticket}\" - 10{leftMatch.ToString()[0]} Jackpot!");
						}
					}
					else
					{
						Console.WriteLine($"ticket \"{ticket}\" - no match");
					}
				}
			}
		}
	}
