using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Alex");
            list.Insert(1, "Bob");
            list.Add("Alexander");

            System.Console.WriteLine("quantos el:" + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            System.Console.WriteLine("First 'A':" + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            System.Console.WriteLine("Last 'A':" + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            System.Console.WriteLine("First position 'A':" + pos1);

            int pos1 = list.FindLastIndex(x => x[0] == 'A');
            System.Console.WriteLine("Last position 'A':" + pos1);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            System.Console.WriteLine("-------------------------");
            foreach (string obj in list2)
            {
                System.Console.WriteLine(obj);
            }

            list.Remove("Alex");
            list.RemoveAt(1);
            list.RemoveAll(x => x[0] == 'M');

            foreach (string obj in list)
            {
                System.Console.WriteLine(obj);
            }

            list.RemoveRange(2, 3);
        }


    }
}