using System;
using System.Linq;
using System.Collections.Generic;

//The code is the same as the problem from the lab. Just the naming of the valiables is a little bit different
namespace _03_Undefined
{
    class Edge
    {
        public int FirstNode { get; set; }
        public int SecondNode { get; set; }
        public int NodeWeight { get; set; }

        public Edge(int firstNode, int secondNode, int nodeWeight)
        {
            this.FirstNode = firstNode;
            this.SecondNode = secondNode;
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
            int[] prev = new int[nodesCount + 1];

            for (int i = 0; i < nodesCount + 1; i++)
            {
                distances[i] = double.PositiveInfinity;
                prev[i] = -1;
            }
            distances[startPoint] = 0;

            for (int i = 0; i < nodesCount - 1; i++)
            {
                bool updated = false;
                foreach (Edge edge in graph)
                {
                    //if (double.IsPositiveInfinity(distances[edge.FirstNode]))
                    //{
                    //    continue;
                    //}

                    double newDistance = distances[edge.FirstNode] + edge.NodeWeight;
                    if (newDistance < distances[edge.SecondNode])
                    {
                        distances[edge.SecondNode] = newDistance;
                        prev[edge.SecondNode] = edge.FirstNode;

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
                //if (double.IsPositiveInfinity(distances[edge.FirstNode]))
                //{
                //    continue;
                //}

                double newDistance = distances[edge.FirstNode] + edge.NodeWeight;
                if (newDistance < distances[edge.SecondNode])
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

                int firstNode = edgeData[0];
                int secondNode = edgeData[1];
                int nodeWeight = edgeData[2];

                Edge edge = new Edge(firstNode, secondNode, nodeWeight);
                result.Add(edge);
            }

            return result;
        }
    }
}
