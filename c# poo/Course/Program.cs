using Course.Entities;
using Course.Entities.Enums;
using System;

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

            Console.WriteLine(order);
            Console.ReadKey(true);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);


            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
        }
    }
}
