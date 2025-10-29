﻿using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);

            }

            SortedSet<int> a = new SortedSet<int>() { 0,2,4,6,8,10};
            SortedSet<int> b = new SortedSet<int>() {5,6,7,8,9,10};

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}