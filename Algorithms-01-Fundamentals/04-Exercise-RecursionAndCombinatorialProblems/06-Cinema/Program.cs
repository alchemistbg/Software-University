using System;
using System.Collections.Generic;

namespace _06_Cinema
{
    class Program
    {
        static List<string> friends;
        static List<int> lockedSeats;

        static void Main(string[] args)
        {
            friends = new List<string> ( Console.ReadLine().Split(", ") );

            lockedSeats = new List<int>(); 
            string command = Console.ReadLine();

            while (command != "generate")
            {
                string[] commandArr = command.Split(" - ");

                string name = commandArr[0];
                int oldSeat = friends.IndexOf(name);
                int desiredSeat = int.Parse(commandArr[1]) - 1;
                
                Swap(oldSeat, desiredSeat);
                lockedSeats.Add(desiredSeat);
                command = Console.ReadLine();
            }

            Permnute(0);
        }

        private static void Permnute(int permuteIndex)
        {
            if (permuteIndex >= friends.Count)
            {
                Console.WriteLine(string.Join(" ", friends));
                return;
            }

            Permnute(permuteIndex + 1);

            for (int i = permuteIndex + 1; i < friends.Count; i++)
            {
                if (!lockedSeats.Contains(permuteIndex) && !lockedSeats.Contains(i))
                {
                    Swap(permuteIndex, i);
                    Permnute(permuteIndex + 1);
                    Swap(permuteIndex, i);
                }
            }
        }

        private static void Swap(int firstElement, int secondElement)
        {
            string temp = friends[firstElement];
            friends[firstElement] = friends[secondElement];
            friends[secondElement] = temp;
        }
    }
}
