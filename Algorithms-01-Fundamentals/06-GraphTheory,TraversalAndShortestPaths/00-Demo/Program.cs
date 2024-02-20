using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_Demo
{
    class Program
    {
        static Dictionary<int, List<int>> graph;
        static HashSet<int> visited;

        static void Main(string[] args)
        {
            visited = new HashSet<int>();

            //Graph for DFS
            graph = new Dictionary<int, List<int>>
            {
                { 1, new List<int>{ 19, 21, 14 } },
                { 19, new List<int>{ 7, 12, 21, 31 } },
                { 21, new List<int>{ 14 } },
                { 14, new List<int>{ 6, 23 } },
                { 7, new List<int>{ 1 } },
                { 12, new List<int>() },
                { 31, new List<int>{ 21 } },
                { 23, new List<int>{ 21} },
                { 6, new List<int>() }
            };

            //int firstNode = graph.Keys.First();
            //DFS_recursive(firstNode);
            //visited.Clear();
            //Console.WriteLine(new string('+', 50));
            //DFS_iterative(firstNode);

            foreach (int node in graph.Keys)
            {
                DFS_recursive(node);
            }
            visited.Clear();
            Console.WriteLine(new string('+', 50));
            foreach (int node in graph.Keys)
            {
                DFS_iterative(node);
            }

            //Graph for BFS
            //graph = new Dictionary<int, List<int>>
            //{
            //    { 7, new List<int>{ 19, 21, 14 } },
            //    { 19, new List<int>{ 1, 12, 21, 31 } },
            //    { 21, new List<int>{ 14 } },
            //    { 14, new List<int>{ 23, 6 } },
            //    { 1, new List<int>{ 7 } },
            //    { 12, new List<int>() },
            //    { 31, new List<int>{ 21 } },
            //    { 6, new List<int>() },
            //    { 23, new List<int>{ 21} },
            //};

            //BFS(graph.Keys.First());
            //foreach (int node in graph.Keys)
            //{
            //    BFS(node);
            //}
        }

        static void DFS_recursive(int node)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            foreach (var child in graph[node])
            {
                DFS_recursive(child);
            }
            Console.WriteLine(node);
        }
        
        static void DFS_iterative(int startNode)
        {
            if (visited.Contains(startNode))
            {
                return;
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(startNode);
            visited.Add(startNode);

            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                Console.WriteLine(currentNode);

                foreach (int child in graph[currentNode])
                {
                    if (!visited.Contains(child))
                    {
                        stack.Push(child);
                        visited.Add(child);
                    }
                }
            }
        }

        static void BFS(int startNode)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                Console.WriteLine(currentNode);

                foreach (int child in graph[currentNode])
                {
                    if (!visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        visited.Add(child);
                    }
                }
            }
        }
    }
}
