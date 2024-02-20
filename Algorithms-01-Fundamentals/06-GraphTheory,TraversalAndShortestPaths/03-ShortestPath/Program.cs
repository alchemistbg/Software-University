using System;
using System.Collections.Generic;

namespace _03_ShortestPath
{
    class Program
    {
        private static Dictionary<int, List<int>> graph;
        private static HashSet<int> visited;
        private static int[] parents;

        static void Main(string[] args)
        {
            graph = ReadGraph();
            visited = new HashSet<int>();
            parents = new int[graph.Count + 1];
            Array.Fill(parents, -1);

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            BFS(start, end);
        }

        private static void BFS(int startNode, int endNode)
        {
            if (visited.Contains(startNode))
            {
                return;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                if (currentNode == endNode)
                {
                    Stack<int> path = ReconstructPath(endNode);
                    Console.WriteLine($"Shortest path length is: {path.Count - 1}");
                    Console.WriteLine(string.Join(" ", path));
                    return;
                }

                foreach (int child in graph[currentNode])
                {
                    if (!visited.Contains(child))
                    {
                        parents[child] = currentNode;
                        queue.Enqueue(child);
                        visited.Add(child);
                    }
                }
            }
        }

        private static Stack<int> ReconstructPath(int end)
        {
            Stack<int> path = new Stack<int>();
            int index = end;

            while (index != -1)
            {
                path.Push(index);
                index = parents[index];
            }

            return path;
        }

        private static Dictionary<int, List<int>> ReadGraph()
        {
            Dictionary<int, List<int>> inputGraph = new Dictionary<int, List<int>>();

            int nodesCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nodesCount; i++)
            {
                inputGraph[i] = new List<int>();
            }

            int edgesCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= edgesCount; i++)
            {
                string[] lineParts = Console.ReadLine().Split(" ");

                int node = int.Parse(lineParts[0]);
                int neighbour = int.Parse(lineParts[1]);

                inputGraph[node].Add(neighbour);
            }
            
            return inputGraph;
        }
    }
}
