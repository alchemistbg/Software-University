using System;
using System.Linq;
using System.Collections.Generic;


namespace _01_Bellman_Ford
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
    }
    class Program
    {
        private static List<Edge> graph;
        static void Main(string[] args)
        {
            int nodesCount = int.Parse(Console.ReadLine());
            int edgesCount = int.Parse(Console.ReadLine());

            graph = ReadGraph(edgesCount);

            int startPoint = int.Parse(Console.ReadLine());
            int endPoint = int.Parse(Console.ReadLine());

            double[] distances = new double[nodesCount + 1];
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = double.PositiveInfinity;
            }

            int[] prev = new int[nodesCount + 1];
            for (int i = 0; i < prev.Length; i++)
            {
                prev[i] = -1;
            }

            distances[startPoint] = 0;

            for (int i = 0; i < nodesCount - 1; i++)
            {
                bool updated = false;
                foreach (Edge edge in graph)
                {
                    //if (double.IsPositiveInfinity(edge.StartNode))
                    //{
                    //    continue;
                    //}

                    double newDistance = distances[edge.StartNode] + edge.NodeWeight;
                    if (newDistance < distances[edge.EndNode])
                    {
                        distances[edge.EndNode] = newDistance;
                        prev[edge.EndNode] = edge.StartNode;

                        updated = true;
                    }
                }

                if (!updated)
                {
                    break;
                }
            }

            foreach (Edge edge in graph)
            {
                //if (double.IsPositiveInfinity(edge.StartNode))
                //{
                //    continue;
                //}

                double newDistance = distances[edge.StartNode] + edge.NodeWeight;
                if (newDistance < distances[edge.EndNode])
                {
                    Console.WriteLine("Undefined");
                    return;
                }
            }

            Stack<int> path = new Stack<int>();
            int node = endPoint;
            while (node != -1)
            {
                path.Push(node);
                node = prev[node];
            }

            Console.WriteLine(string.Join(" ", path));
            Console.WriteLine(distances[endPoint]);
        }

        private static List<Edge> ReadGraph(int edgesCount)
        {
            List<Edge> result = new List<Edge>();
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
                result.Add(edge);
            }

            return result;
        }
    }
}
