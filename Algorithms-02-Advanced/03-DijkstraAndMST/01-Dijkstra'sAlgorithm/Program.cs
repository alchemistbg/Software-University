using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;


namespace _01_Dijkstra_sAlgorithm
{
    public class Edge
    {
        public int FirstNode { get; set; }

        public int SecondNode { get; set; }

        public int EdgeWeight { get; set; }

        public override string ToString()
        {
            return $"{FirstNode}:{SecondNode} -> {EdgeWeight}";
        }
    }

    class Program
    {
        public static Dictionary<int, List<Edge>> graph;

        static void Main(string[] args)
        {
            int edges = int.Parse(Console.ReadLine());
            graph = ReadGraph(edges);

            int startNode = int.Parse(Console.ReadLine());
            int endNode = int.Parse(Console.ReadLine());

            int nodeMaxValue = graph.Keys.Max();
            int[] distances = new int[nodeMaxValue + 1];

            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
            }
            distances[startNode] = 0;

            int[] prev = new int[nodeMaxValue + 1];
            prev[startNode] = -1;

            OrderedBag<int> queue = new OrderedBag<int>(
                Comparer<int>.Create(   
                    (f, s) => distances[f] - distances[s]
                ));
            queue.Add(startNode);

            while (queue.Count > 0)
            {
                int currentNode = queue.RemoveFirst();
                if (currentNode == endNode)
                {
                    break;
                }

                List<Edge> children = graph[currentNode];

                foreach (Edge child in children)
                {
                    int childNodeValue = (child.FirstNode == currentNode ? child.SecondNode : child.FirstNode);

                    if (distances[childNodeValue] == int.MaxValue)
                    {
                        queue.Add(childNodeValue);
                    }

                    int newDistance = distances[currentNode] + child.EdgeWeight;
                    if (newDistance < distances[childNodeValue])
                    {
                        distances[childNodeValue] = newDistance;
                        queue = new OrderedBag<int>(queue, Comparer<int>.Create((f, s) => distances[f] - distances[s]));

                        prev[childNodeValue] = currentNode;
                    }
                }
            }

            PrintResult(endNode, distances, prev);
        }

        private static void PrintResult(int endNode, int[] distances, int[] prev)
        {
            if (distances[endNode] == int.MaxValue)
            {
                Console.WriteLine("There is no such path.");
            }
            else
            {
                Console.WriteLine(distances[endNode]);

                Stack<int> path = new Stack<int>();
                int node = endNode;

                while (node != -1)
                {
                    path.Push(node);
                    node = prev[node];
                }

                Console.WriteLine(string.Join(" ", path));
            }
        }

        public static Dictionary<int, List<Edge>> ReadGraph(int edges)
        {
            Dictionary<int, List<Edge>> result = new Dictionary<int, List<Edge>>();

            for (int i = 0; i < edges; i++)
            {
                int[] edgeData = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstNode = edgeData[0];
                int secondNode = edgeData[1];
                int edgeWeight = edgeData[2];

                if (!result.ContainsKey(firstNode))
                {
                    result[firstNode] = new List<Edge>();
                }

                if (!result.ContainsKey(secondNode))
                {
                    result[secondNode] = new List<Edge>();
                }

                Edge edge = new Edge
                {
                    FirstNode = firstNode,
                    SecondNode = secondNode,
                    EdgeWeight = edgeWeight
                };

                result[firstNode].Add(edge);
                result[secondNode].Add(edge);
            }

            return result;
        }
    }
}
