using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int n3 = n1 / n2;

                System.Console.WriteLine(n3);
            } /*catch ( Exception e )
            {
                System.Console.WriteLine("Error" + e.Message);
            }*/
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("Dividing by 0 is not allowed!!!!!!!!!!!!!!!!!!!!!");
            }
            catch (FormatException e)
            {
                System.Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}