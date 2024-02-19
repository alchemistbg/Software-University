using System;
using System.Linq;

namespace _01_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int query = int.Parse(Console.ReadLine());

            int result = PerformBinarySearch(elements, query, 0, elements.Length - 1);
            Console.WriteLine(result);
        }

        private static int PerformBinarySearch(int[] elements, int query, int start, int end)
        {
            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (query == elements[mid])
                {
                    return mid;
                }

                if (query > elements[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return -1;
            //if (query == elements[mid])
            //{
            //    result = mid;
            //}
            //else if (query < elements[mid])
            //{
            //    end = mid;
            //    return PerformBinarySearch(elements, query, start, end);
            //}
            //else if (query > elements[mid])
            //{
            //    start = mid + 1;
            //    return PerformBinarySearch(elements, query, start, end);
            //}

            //return result;

            //return PerformBinarySearch(elements, query, start, end);
        }
    }
}
