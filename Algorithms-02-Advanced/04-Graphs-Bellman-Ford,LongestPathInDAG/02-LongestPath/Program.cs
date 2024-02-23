using System;
using System.Linq;
using System.Collections.Generic;

namespace _02_LongestPath
{

    class Edge
    {
        public int StartNode { get; set; }
        public int EndNode { get; set; }
        public int NodeWeight { get; set; }

        public Edge(int startNode, int endNode, int nodeWeight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.NodeWeight = nodeWeight;
        }

        public override string ToString()
        {
            return $"{this.StartNode} -> {this.EndNode} = {NodeWeight}";
        }
    }

    class Program
    {

        public static List<Edge>[] graph;
        public static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            int edgesCount = int.Parse(Console.ReadLine());

            graph = ReadGraph(edgesCount);
            
            int startNode = int.Parse(Console.ReadLine());
            int endNode = int.Parse(Console.ReadLine());

            Stack<int> sortedNodes = TopologicalSorting(nodesCount);

            int[] prev = new int[nodesCount + 1];
            for (int i = 0; i < prev.Length; i++)
            {
                prev[i] = -1;
            }

            double[] distances = new double[nodesCount + 1];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = double.NegativeInfinity;
            } 
            distances[startNode] = 0;

            while (sortedNodes.Count > 0)
            {
                var currentNode = sortedNodes.Pop();
                foreach (Edge edge in graph[currentNode])
                {
                    double newDistance = distances[currentNode] + edge.NodeWeight;
                    if (distances[edge.EndNode] < newDistance)
                    {
                        distances[edge.EndNode] = newDistance;
                        prev[edge.EndNode] = edge.StartNode;
                    }
                }
            }

            Console.WriteLine(distances[endNode]);

            Stack<int> path = new Stack<int>();
            int node = endNode;
            while (node != -1)
            {
                path.Push(node);
                node = prev[node];
            }

            Console.WriteLine(string.Join("; ", path));
        }

        private static Stack<int> TopologicalSorting(int nodesCount)
        {
            bool[] visited = new bool[graph.Length];
            Stack<int> sortedNodes = new Stack<int>();

            for (int node = 1; node < graph.Length; node++)
            {
                DFS(node, visited, sortedNodes);
            }
            ;
            return sortedNodes;
        }

        private static void DFS(int node, bool[] visited, Stack<int> sortedNodes)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (Edge edge in graph[node])
            {
                DFS(edge.EndNode, visited, sortedNodes);
            }

            sortedNodes.Push(node);
        }

        private static List<Edge>[] ReadGraph(int edgesCount)
        {
            List<Edge>[] result = new List<Edge>[edgesCount + 1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new List<Edge>();
            }

            for (int i = 0; i < edgesCount; i++)
            {

                int[] edgeData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int startNode = edgeData[0];
                int endNode = edgeData[1];
                int nodeWeight = edgeData[2];

                Edge edge = new Edge(startNode, endNode, nodeWeight);

                result[startNode].Add(edge);
            }

            return result;
        }
    }
}
