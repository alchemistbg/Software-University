using System;
using System.Collections.Generic;
//using Problem01.List;

namespace SomeTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> testMyList = new List<int>();
            testMyList.Add(101);
            Console.WriteLine(testMyList.Capacity);
            //testMyList.Add(1);
            //testMyList.Add(2);
            //testMyList.Add(3);
            //testMyList.Add(4);
            //testMyList.Add(5);
            //testMyList.Remove(3);
            //testMyList.RemoveAt(0);

            //int[] intArr = testMyList.ToArray();
            //Console.WriteLine(intArr.Length);

            //foreach (int item in intArr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Capacity: {testMyList.Capacity}");
            //Console.WriteLine($"Count: {testMyList.Count}");

            //for (int i = 0; i < 9; i++)
            //{
            //    int intToAdd = (i + 1) * 2;
            //    Console.WriteLine($"Now adding {intToAdd} at position {i}");
            //    testMyList.Add(intToAdd);
            //    Console.WriteLine($"Capacity now is: {testMyList.Capacity}");
            //    Console.WriteLine($"Count now is: {testMyList.Count}");
            //}

            //for (int i = 8; i >= 0; i--)
            //{
            //    Console.WriteLine($"Now removing from position {i}");
            //    testMyList.RemoveAt(i);
            //    Console.WriteLine($"Capacity now is: {testMyList.Capacity}");
            //    Console.WriteLine($"Count now is: {testMyList.Count}");
            //}
        }

        public static bool boolTest(int input)
        {
            return input != -1;
        }
        //public static bool Test(int testInt)
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        if (i == testInt)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
