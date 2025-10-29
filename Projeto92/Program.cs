using System;
using System.IO;
using System.Collections.Generic;
using Coruse.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee employee in list)
                    {
                        System.Console.WriteLine(employee);
                    }
                }
            } catch (IOException e)
            {
                System.Console.WriteLine("An error ocurred");
                System.Console.WriteLine(e.Message);

            }
        }
    }
}