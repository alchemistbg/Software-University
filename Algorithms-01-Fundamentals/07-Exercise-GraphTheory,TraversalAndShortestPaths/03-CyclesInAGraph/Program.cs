using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_CyclesInAGraph
{
    class Program
    {

        static Dictionary<char, List<char>> graph;
        static HashSet<char> visited;
        static HashSet<char> recursionStack;
        static void Main(string[] args)
        {
            graph = ReadGraph();

            visited = new HashSet<char>();
            recursionStack = new HashSet<char>();

            foreach (char node in graph.Keys)
            {
                try
                {
                    DFS(node);
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Acyclic: No");
                    return;
                }
            }
            Console.WriteLine("Acyclic: Yes");
        }

        private static void DFS(char node)
        {
            if (recursionStack.Contains(node))
            {
                throw new InvalidOperationException();
            }

            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            recursionStack.Add(node);

            //This is my solution for a case when graph dictionary doesn't contains the node
            //if (graph.ContainsKey(node))
            //{
                foreach (char child in graph[node])
                {
                    DFS(child);
                }

                recursionStack.Remove(node);
            //}
        }

        private static Dictionary<char, List<char>> ReadGraph()
        {
            Dictionary<char, List<char>> result = new Dictionary<char, List<char>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                char[] line = input.ToCharArray();
                char node = line[0];
                char child = line[2];
                
                /*Another variant for parsing input.
                It could be slow because of using LINQ
                
                char[] line = input
                    .Split('-')
                    .Select(char.Parse)
                    .ToArray();
                char node = line[0];
                char child = line[1];
                */

                if (!result.ContainsKey(line[0]))
                {
                    result.Add(node, new List<char>());
                }

                //This is lector's solution for a case when graph dictionary doesn't contains the node
                if (!result.ContainsKey(child))
                {
                    result.Add(child, new List<char>());
                }

                result[node].Add(child);

                input = Console.ReadLine();
            }

            return result;
        }
    }
}
