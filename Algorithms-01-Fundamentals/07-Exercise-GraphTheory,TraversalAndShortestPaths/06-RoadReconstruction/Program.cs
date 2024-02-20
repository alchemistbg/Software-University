using System;
using System.Collections.Generic;
using System.Linq;

/*
* The solution of this task uses practically the same code as the 'BreakCycles' task.
* There is just one main difference:
* The boolean check with 'isPathExists' variable is with reversed logic.
* Another not so important difference is that printing is different.
* Need to fix the variables and methods naming to better reflect the task context
*/

namespace _06_RoadReconstruction
{
    class Edge
    {
        public int StartNode { get; set; }
        public int EndNode { get; set; }

        public Edge(int startNode, int endNode)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
        }
    }
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static List<Edge> edges;
        static HashSet<int> visited;
        static List<Edge> importantEdges;
        static void Main(string[] args)
        {
            graph = new Dictionary<int, List<int>>();
            edges = new List<Edge>();

            importantEdges = new List<Edge>();
            visited = new HashSet<int>();

            ParseInput();

            foreach (Edge edge in edges)
            {
                int startNode = edge.StartNode;
                int endNode = edge.EndNode;

                if (!graph[startNode].Contains(endNode))
                {
                    continue;
                }

                graph[startNode].Remove(endNode);
                graph[endNode].Remove(startNode);

                bool isPathExists = CheckIfPathExists(startNode, endNode);
                if (!isPathExists)
                {
                    importantEdges.Add(edge);
                }
                else
                {
                    graph[startNode].Add(endNode);
                    graph[endNode].Add(startNode);
                }

                visited = new HashSet<int>();
            }

            Console.WriteLine("Important streets:");
            foreach (Edge edge in importantEdges)
            {
                int start = Math.Min(edge.StartNode, edge.EndNode);
                int end = Math.Max(edge.StartNode, edge.EndNode);
                Console.WriteLine($"{start} {end}");
            }
        }

        private static bool CheckIfPathExists(int startNode, int endNode)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();

                if (currentNode == endNode)
                {
                    return true;
                }

                foreach (int child in graph[currentNode])
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

        private static void ParseInput()
        {
            int buildings = int.Parse(Console.ReadLine());
            int roads = int.Parse(Console.ReadLine());

            for (int i = 0; i < roads; i++)
            {
                int[] line = Console.ReadLine().Split(" - ").Select(int.Parse).ToArray();
                int startNode = line[0];
                int endNode = line[1];

                if (!graph.ContainsKey(startNode))
                {
                    graph.Add(startNode, new List<int>());
                }

                if (!graph.ContainsKey(endNode))
                {
                    graph.Add(endNode, new List<int>());
                }

                graph[startNode].Add(endNode);
                graph[endNode].Add(startNode);

                edges.Add(new Edge(startNode, endNode));
            }
        }
    }
}
