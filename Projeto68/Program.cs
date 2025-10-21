using System;
using System.Data.Common;
using Course.Entitites;
using Course.Entitites.enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            System.Console.WriteLine(order);

            string txt = OrderStauts.PendingPayment.ToString();
            System.Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            System.Console.WriteLine(os);
            
        }
    }
}