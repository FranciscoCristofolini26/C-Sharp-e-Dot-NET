using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 2000.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 2000.0); //outro obj na memoria
            System.Console.WriteLine(a.Contains(prod));//false pois compara pelo hash

            Point p = new Point(5, 10);
            System.Console.WriteLine(b.Contains(p));

        }
    }
}