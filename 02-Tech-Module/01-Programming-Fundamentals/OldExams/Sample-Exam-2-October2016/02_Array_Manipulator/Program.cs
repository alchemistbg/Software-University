using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Array_Manipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

			string command = Console.ReadLine();
			while (command != "end")
			{
				string[] commArr = command.Split(' ');
				string comm0 = commArr[0];
				string comm1 = commArr[1];
				if (comm0.Equals("exchange"))
				{
					int splitPos = int.Parse(comm1);
					if (splitPos < 0 || splitPos > input.Count - 1)
					{
						Console.WriteLine("Invalid index");
					}
					else
					{
						for (int i = 0; i <= splitPos; i++)
						{
							int temp = input[0];
							for (int j = 1; j < input.Count; j++)
							{
								input[j - 1] = input[j];
							}
							input[input.Count - 1] = temp;
						}
					}
				}
				if (comm0.Equals("max"))
				{
					List<int> temp = new List<int>();
					if (comm1.Equals("odd"))
					{
						temp = input.Where(x => x % 2 != 0).ToList();
						if (temp.Count() == 0)
						{
							Console.WriteLine("No matches");
						}
						else
						{
							Console.WriteLine(input.LastIndexOf(temp.Max()));
						}
					}
					else
					{
						temp = input.Where(x => x % 2 == 0).ToList();
						if (temp.Count() == 0)
						{
							Console.WriteLine("No matches");
						}
						else
						{
							Console.WriteLine(input.LastIndexOf(temp.Max()));
						}
					}
				}

				if (comm0.Equals("min"))
				{
					List<int> temp = new List<int>();
					if (comm1.Equals("odd"))
					{
						temp = input.Where(x => x % 2 != 0).ToList();
						if (temp.Count() == 0)
						{
							Console.WriteLine("No matches");
						}
						else
						{
							Console.WriteLine(input.LastIndexOf(temp.Min()));
						}
					}
					else
					{
						temp = input.Where(x => x % 2 == 0).ToList();
						if (temp.Count() == 0)
						{
							Console.WriteLine("No matches");
						}
						else
						{
							Console.WriteLine(input.LastIndexOf(temp.Min()));
						}
					}
				}

				if (comm0.Equals("first"))
				{
					int elements = int.Parse(comm1);
					if (elements > input.Count())
					{
						Console.WriteLine("Invalid count");
					}
					else
					{
						string type = commArr[2];

						List<int> temp = new List<int>();
						if (type.Equals("odd"))
						{
							temp = input.Where(x => x % 2 != 0).ToList();
							Console.WriteLine("[" + string.Join(", ", temp.Take(elements)) + "]");
						}
						else
						{
							temp = input.Where(x => x % 2 == 0).ToList();
							Console.WriteLine("[" + string.Join(", ", temp.Take(elements)) + "]");
						}
					}					
				}

				if (comm0.Equals("last"))
				{
					int elements = int.Parse(comm1);
					if (elements > input.Count())
					{
						Console.WriteLine("Invalid count");
					}
					else
					{
						string type = commArr[2];

						List<int> temp = new List<int>();
						if (type.Equals("odd"))
						{
							input.Reverse();
							temp = input.Where(x => x % 2 != 0).ToList();
							//temp.Reverse();
							input.Reverse();
							Console.WriteLine("[" + string.Join(", ", temp.Take(elements).Reverse()) + "]");
						}
						else
						{
							input.Reverse();
							temp = input.Where(x => x % 2 == 0).ToList();
							//temp.Reverse();
							input.Reverse();
							Console.WriteLine("[" + string.Join(", ", temp.Take(elements).Reverse()) + "]");
						}
					}
				}
				command = Console.ReadLine();
			}
			Console.WriteLine("[" + string.Join(", ", input) + "]");
		}
	}
}
