using System;
using Exercicio.Entities;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter full file path:");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(",");

                    string name = lines[0];
                    string email = lines[1];
                    double salary = double.Parse(lines[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }


            }

            System.Console.WriteLine("Enter salary:");
            double salaryF = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine($"-Email of people whose salary is more than {salaryF}:");

            var verSalary = list.Where(e => e.Salary > salaryF).OrderByDescending(e => e.Email).Select(e => e.Email);
            foreach (string email in verSalary)
            {
                System.Console.WriteLine(email);
            }

      

            var mPeople = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();
 

            System.Console.WriteLine($"Sum of salary of people whose name starts with 'M': {mPeople}");
        }
    }
}