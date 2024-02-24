using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace _03
{
    public class Connection
    {
        public int FirstRoom { get; set; }
        public int SecondRoom { get; set; }
        public int Time { get; set; }

        public Connection(int firstRoom, int secondRoom, int time)
        {
            FirstRoom = firstRoom;
            SecondRoom = secondRoom;
            Time = time;
        }
    }

    class Program
    {
        public static SortedDictionary<int, List<Connection>> graph;

        public static void Main(string[] args)
        {
            int roomsCount = int.Parse(Console.ReadLine());
            int[] exits = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int connectionsCount = int.Parse(Console.ReadLine());

            graph = ReadGraph(connectionsCount);

            int timeLimit = StringToSeconds(Console.ReadLine());

            long[] times = new long[roomsCount];
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = int.MaxValue;
                if (exits.Contains(i))
                {
                    times[i] = 0;
                }
            }

            foreach (int exit in exits)
            {
                int startNode = exit;
                foreach (int room in graph.Keys.ToArray())
                {
                    if (!exits.Contains(room))
                    {
                        int endNode = room;

                        OrderedBag<int> queue = new OrderedBag<int>(
                                                Comparer<int>.Create(
                                                    (f, s) => times[f].CompareTo(times[s])
                ));
                        queue.Add(startNode);

                        while (queue.Count > 0)
                        {
                            int currentNode = queue.RemoveFirst();
                            //if (currentNode == endNode)
                            //{
                            //    break;
                            //}

                            List<Connection> children = graph[currentNode];

                            foreach (Connection child in children)
                            {
                                int childNodeValue = (child.FirstRoom == currentNode ? child.SecondRoom : child.FirstRoom);

                                if (times[childNodeValue] == int.MaxValue)
                                {
                                    queue.Add(childNodeValue);
                                }

                                long newDistance = times[currentNode] + child.Time;
                                if (newDistance < times[childNodeValue])
                                {
                                    times[childNodeValue] = newDistance;
                                    queue = new OrderedBag<int>(queue, Comparer<int>.Create((f, s) => times[f].CompareTo(times[s])));
                                }
                            }
                        }
                    }
                }
            }
            ;
            Print(exits, times, timeLimit);
        }

        private static void Print(int[] exits, long[] times, int timeLimit)
        {
            for (int i = 0; i < times.Length; i++)
            {
                if (!exits.Contains(i))
                {
                    if (times[i] == int.MaxValue)
                    {
                        Console.WriteLine($"Unreachable {i} (N/A)");
                    }
                    else if (times[i] > timeLimit)
                    {
                        Console.WriteLine($"Unsafe {i} ({SecondsToString(times[i])})");
                    }
                    else
                    {
                        Console.WriteLine($"Safe {i} ({SecondsToString(times[i])})");
                    }
                }
            }
        }

        private static SortedDictionary<int, List<Connection>> ReadGraph(int connectionsCount)
        {
            SortedDictionary<int, List<Connection>> result = new SortedDictionary<int, List<Connection>>();

            for (int i = 0; i < connectionsCount; i++)
            {
                string[] connectionData = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                int firstRoom = int.Parse(connectionData[0]);
                int secondRoom = int.Parse(connectionData[1]);
                int time = StringToSeconds(connectionData[2]);

                if (!result.Keys.Contains(firstRoom))
                {
                    result.Add(firstRoom, new List<Connection>());
                }

                if (!result.Keys.Contains(secondRoom))
                {
                    result.Add(secondRoom, new List<Connection>());
                }

                Connection connection = new Connection(firstRoom, secondRoom, time);

                result[firstRoom].Add(connection);
                result[secondRoom].Add(connection);
            }

            return result;
        }

        private static int StringToSeconds(string timeString)
        {
            string[] time = timeString.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
            int minutes = int.Parse(time[0]);
            int seconds = int.Parse(time[1]);

            int timeInSeconds = minutes * 60 + seconds;
            return timeInSeconds;
        }

        private static string SecondsToString(long totalSeconds)
        {
            long hours = totalSeconds / 3600;
            totalSeconds -= hours * 3600;

            long minutes = totalSeconds / 60;
            totalSeconds -= minutes * 60;

            long seconds = totalSeconds;

            string timeString = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            return timeString;
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Wintellect.PowerCollections;

//namespace _03
//{
//    public class Connection
//    {
//        public int FirstRoom { get; set; }
//        public int SecondRoom { get; set; }
//        public int Time { get; set; }

//        public Connection(int firstRoom, int secondRoom, int time)
//        {
//            FirstRoom = firstRoom;
//            SecondRoom = secondRoom;
//            Time = time;
//        }
//    }

//    class Program
//    {
//        public static SortedDictionary<int, List<Connection>> graph;

//        public static void Main(string[] args)
//        {
//            int roomsCount = int.Parse(Console.ReadLine());
//            int[] exits = Console.ReadLine().Split().Select(int.Parse).ToArray();
//            int connectionsCount = int.Parse(Console.ReadLine());

//            graph = ReadGraph(connectionsCount);

//            int timeLimit = StringToSeconds(Console.ReadLine());

//            long[] times = new long[roomsCount];
//            for (int i = 0; i < times.Length; i++)
//            {
//                times[i] = long.MaxValue;
//                if (exits.Contains(i))
//                {
//                    times[i] = 0;
//                }
//            }

//            foreach (int room in graph.Keys.ToArray())
//            {
//                int endNode = room;

//                foreach (int exit in exits)
//                {
//                    if (!exits.Contains(room))
//                    {
//                        int startNode = exit;

//                        OrderedBag<int> queue = new OrderedBag<int>(
//                                                Comparer<int>.Create(
//                                                    (f, s) => times[f].CompareTo(times[s])));

//                        queue.Add(startNode);

//                        while (queue.Count > 0)
//                        {
//                            int currentNode = queue.RemoveFirst();

//                            if (currentNode == endNode)
//                            {
//                                break;
//                            }

//                            List<Connection> children = graph[currentNode];

//                            foreach (Connection child in children)
//                            {
//                                int childNodeValue = (child.FirstRoom == currentNode ? child.SecondRoom : child.FirstRoom);

//                                if (times[childNodeValue] == int.MaxValue)
//                                {
//                                    queue.Add(childNodeValue);
//                                }

//                                long newTime = times[currentNode] + child.Time;
//                                if (newTime < times[childNodeValue])
//                                {
//                                    times[childNodeValue] = newTime;
//                                    queue = new OrderedBag<int>(queue, Comparer<int>.Create((f, s) => times[f].CompareTo(times[s])));
//                                }
//                            }
//                        }
//                    }
//                }
//            }

//            Print(exits, times, timeLimit);
//        }

//        private static void Print(int[] exits, long[] times, int timeLimit)
//        {
//            for (int i = 0; i < times.Length; i++)
//            {
//                if (!exits.Contains(i))
//                {
//                    if (times[i] == int.MaxValue)
//                    {
//                        Console.WriteLine($"Unreachable {i} (N/A)");
//                    }
//                    else if (times[i] > timeLimit)
//                    {
//                        Console.WriteLine($"Unsafe {i} ({SecondsToString(times[i])})");
//                    }
//                    else
//                    {
//                        Console.WriteLine($"Safe {i} ({SecondsToString(times[i])})");
//                    }
//                }
//            }
//        }

//        private static SortedDictionary<int, List<Connection>> ReadGraph(int connectionsCount)
//        {
//            SortedDictionary<int, List<Connection>> result = new SortedDictionary<int, List<Connection>>();

//            for (int i = 0; i < connectionsCount; i++)
//            {
//                string[] connectionData = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

//                int firstRoom = int.Parse(connectionData[0]);
//                int secondRoom = int.Parse(connectionData[1]);
//                int time = StringToSeconds(connectionData[2]);

//                if (!result.Keys.Contains(firstRoom))
//                {
//                    result.Add(firstRoom, new List<Connection>());
//                }

//                if (!result.Keys.Contains(secondRoom))
//                {
//                    result.Add(secondRoom, new List<Connection>());
//                }

//                Connection connection = new Connection(firstRoom, secondRoom, time);

//                result[firstRoom].Add(connection);
//                result[secondRoom].Add(connection);
//            }

//            return result;
//        }

//        private static int StringToSeconds(string timeString)
//        {
//            string[] time = timeString.Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
//            int minutes = int.Parse(time[0]);
//            int seconds = int.Parse(time[1]);

//            int timeInSeconds = minutes * 60 + seconds;
//            return timeInSeconds;
//        }

//        private static string SecondsToString(long totalSeconds)
//        {
//            //Console.WriteLine(totalSeconds);
//            long hours = totalSeconds / 3600;
//            totalSeconds -= hours * 3600;

//            long minutes = totalSeconds / 60;
//            totalSeconds -= minutes * 60;

//            long seconds = totalSeconds;

//            string timeString = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
//            return timeString;
//        }
//    }
//}
