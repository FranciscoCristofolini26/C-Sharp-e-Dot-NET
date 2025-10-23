using System;
using Course.Entities;
using Course.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            System.Console.WriteLine("Enter the number of shapes:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Shape #{i} data:");
                System.Console.WriteLine("Rectangle or Circle (r/c)?");
                char ch = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Color (Black/Blue/Red):");
                Cor color = Enum.Parse<Cor>(Console.ReadLine());


                if (ch == 'r')
                {
                    System.Console.WriteLine("Width:");
                    double width = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Height:");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Retangle(width, height, color));
                }
                else
                {
                    System.Console.WriteLine("radius:");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }


            }
            
            System.Console.WriteLine();
                System.Console.WriteLine("SHAPE AREAS");
                foreach (Shape shape in list)
                {
                    System.Console.WriteLine(shape.Area().ToString());
                }

        }
    }
}