using System;
using System.Collections.Generic;

namespace _03_Immune_System
{
	class Program
	{
		static void Main(string[] args)
		{
			int systemHealthInitial = int.Parse(Console.ReadLine());
			int systemHealthCurrent = systemHealthInitial;
			Dictionary<String, int> virusDB = new Dictionary<string, int>();
			String attack = Console.ReadLine();
			bool def = false;

			while (!attack.Equals("end"))
			{
				int vPower = calcVirusPower(attack);
				int defTime = 0;
				if (!virusDB.ContainsKey(attack))
				{
					virusDB.Add(attack, vPower);
					defTime = calcDefTime(attack, vPower, false);
				}
				else
				{
					defTime = calcDefTime(attack, vPower, true);
				}
				Console.WriteLine($"Virus {attack}: {virusDB[attack]} => {defTime} seconds");
				if (defTime < systemHealthCurrent)
				{
					Console.WriteLine($"{attack} defeated in {convertTime(defTime)}.");
					systemHealthCurrent -= defTime;
					Console.WriteLine($"Remaining health: {systemHealthCurrent}");

					double healthBonus = systemHealthCurrent * 0.2;
					systemHealthCurrent += (int)healthBonus;
					if (systemHealthInitial <= systemHealthCurrent)
					{
						systemHealthCurrent = systemHealthInitial;
					}
					attack = Console.ReadLine();
				}
				else
				{
					Console.WriteLine("Immune System Defeated.");
					def = true;
					break;
				}
			}
			if (def)
			{

			}
			else
			{
				printFinal(systemHealthCurrent);
			}

		}

		public static int calcVirusPower(String virusName)
		{
			int virusPower = 0;
			char[] virusChars = virusName.ToCharArray();
			foreach (char ch in virusChars)
			{
				virusPower += ch;
			}
			virusPower = (int)virusPower / 3;

			return virusPower;
		}

		public static int calcDefTime(string vName, int vPower, bool b)
		{
			int vL = vName.Length;
			int defTime = vPower * vL;
			if (b)
			{
				defTime = defTime / 3;
			}
			return defTime;
		}

		public static String convertTime(int seconds)
		{
			String m = $"{seconds / 60}m {seconds % 60}s";
			return m;
		}

		public static void printFinal(int h)
		{
			Console.WriteLine($"Final Health: {h}");
		}
	}
}
