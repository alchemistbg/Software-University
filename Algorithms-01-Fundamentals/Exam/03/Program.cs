using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static List<int>[] paths;
        static void Main(string[] args)
        {
            graph = ReadGraph();

            paths = ReadPaths();

            foreach (List<int> path in paths)
            {
                bool ifPathExists = CheckIfPathExists(path);

                if (ifPathExists)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }

        private static bool CheckIfPathExists(List<int> path)
        {
            Queue<int> queue = new Queue<int>();

            int count = 0;
            queue.Enqueue(path[count]);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                count++;

                if (graph[currentNode].Contains(path[count]))
                {
                    if (count == path.Count - 1)
                    {
                        break;
                    }

                    queue.Enqueue(path[count]);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static Dictionary<int, List<int>> ReadGraph()
        {
            int nodesCount = int.Parse(Console.ReadLine());

            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

            for (int i = 0; i < nodesCount; i++)
            {
                result.Add(i, new List<int>());

                string line = Console.ReadLine();
                if (!String.IsNullOrEmpty(line))
                {
                    List<int> children = line.Split().Select(int.Parse).ToList();
                    result[i].AddRange(children);
                }
            }

            return result;
        }

        private static List<int>[] ReadPaths()
        {
            int pathsCounter = int.Parse(Console.ReadLine());

            List<int>[] result = new List<int>[pathsCounter];

            for (int i = 0; i < pathsCounter; i++)
            {
                string line = Console.ReadLine();
                result[i] = line.Split().Select(int.Parse).ToList();
            }

            return result;
        }
    }
}
