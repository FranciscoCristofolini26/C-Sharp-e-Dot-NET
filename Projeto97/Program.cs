using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            System.Console.WriteLine("Enter file full Path");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    System.Console.WriteLine("Total users:" + set.Count);
                }
            } catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}