using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Alex";
            cookies["email"] = "alex@gmail.com";
            cookies["phone"] = "9988349324";
            cookies["phone"] = "1323432434";

            System.Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                System.Console.WriteLine(cookies["email"]);
            }
            else
            {
                System.Console.WriteLine("There is no 'email' key");
            }

            System.Console.WriteLine("Size: " + cookies.Count);

            System.Console.WriteLine("All cookies:");

            foreach (KeyValuePair<string, string> item in cookies)
            {
                System.Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}

