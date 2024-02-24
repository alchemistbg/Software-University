using System;
using System.Collections.Generic;
using System.Linq;


//Some more optimizations can be made... Check the lecture again

namespace _02_Knapsack
{
    class Item
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            List<Item> items = ReadItems();

            int[,] matrix = new int[items.Count + 1, capacity + 1];
            bool[,] selected = new bool[items.Count + 1, capacity + 1];

            for (int r = 1; r < matrix.GetLength(0); r++)
            {
                Item currentItem = items[r - 1];
                for (int c = 1; c < matrix.GetLength(1); c++)
                {
                    int skip = matrix[r - 1, c];

                    if (currentItem.Weight > c)
                    {
                        matrix[r, c] = skip;
                        continue;
                    }

                    int take = currentItem.Value + matrix[r - 1, c - currentItem.Weight];

                    if (take > skip)
                    {
                        matrix[r, c] = take;
                        selected[r, c] = true;
                    }
                    else
                    {
                        matrix[r, c] = skip;
                    }
                }
            }

            int totalValue = matrix[items.Count, capacity];

            SortedSet<Item> selectedItems = new SortedSet<Item>(
                Comparer<Item>.Create((f, s) => string.Compare(f.Name, s.Name, StringComparison.Ordinal))
                );

            for (int r = selected.GetLength(0) - 1; r >= 0; r--)
            {
                if (selected[r, capacity])
                {
                    selectedItems.Add(items[r - 1].Name);
                    capacity -= items[r - 1].Weight;
                }
            }

            int totalWeight = selectedItems.Sum(Item => Item.Weight);
            Console.WriteLine($"Total Weight: {totalWeight}");
            Console.WriteLine($"Total Value: {totalValue}");

            foreach (Item item in selectedItems)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static List<Item> ReadItems()
        {
            List<Item> result = new List<Item>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] itemData = line.Split();
                line = Console.ReadLine();

                result.Add(new Item
                {
                    Name = itemData[0],
                    Weight = int.Parse(itemData[1]),
                    Value = int.Parse(itemData[2]),
                }
                );
            }

            return result;
        }
    }
}
