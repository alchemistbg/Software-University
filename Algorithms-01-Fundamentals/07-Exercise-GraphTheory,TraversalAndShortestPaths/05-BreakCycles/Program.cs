using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BreakCycles
{
    class Edge
    {
        public Edge(string startNode, string endNode)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
        }

        public string StartNode { get; set; }

        public string EndNode { get; set; }
    }

    class Program
    {
        static Dictionary<string, List<string>> graph;
        static List<Edge> edges;
        static HashSet<string> visited;
        static List<Edge> edgesToRemove;

        static void Main(string[] args)
        {
            graph = new Dictionary<string, List<string>>();
            edges = new List<Edge>();
            visited = new HashSet<string>();
            edgesToRemove = new List<Edge>();

            ReadInput();

            edges = edges
                .OrderBy(e => e.StartNode)
                .ThenBy(e => e.EndNode)
                .ToList();

            foreach (var edge in edges)
            {
                string start = edge.StartNode;
                string end = edge.EndNode;

                if (!graph[start].Contains(end))
                {
                    continue;
                }

                graph[start].Remove(end);
                graph[end].Remove(start);

                bool isPathExists = CheckIfPathExists(start, end);
                if (isPathExists)
                {
                    edgesToRemove.Add(edge);
                }
                else
                {
                    graph[start].Add(end);
                    graph[end].Add(start);
                }

                visited = new HashSet<string>();
            }

            Console.WriteLine($"Edges to remove: {edgesToRemove.Count}");

            foreach (var edge in edgesToRemove)
            {
                Console.WriteLine($"{edge.StartNode} - {edge.EndNode}");
            }
        }

        private static bool CheckIfPathExists(string start, string end)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);
            visited.Add(start);

            while (queue.Count > 0)
            {
                string currentNode = queue.Dequeue();

                if (currentNode == end)
                {
                    return true;
                }

                foreach (string child in graph[currentNode])
                {
                    if (!visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        visited.Add(child);
                    }
                }
            }

            return false;
        }

        private static void ReadInput()
        {
            int inputCounter = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCounter; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string node = line[0];
                List<string> children = line[1]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (!graph.ContainsKey(node))
                {
                    graph.Add(node, new List<string>());
                }

                foreach (string child in children)
                {
                    edges.Add(new Edge(node, child));
                }

                graph[node] = children;
            }
        }
    }
}

