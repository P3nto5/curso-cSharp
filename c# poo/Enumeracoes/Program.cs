using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;

namespace Enumeracoes
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

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

              OrderStatus os;
              Enum.TryParse("Delivered", true, out os);
             Console.WriteLine(os);
        
            Console.ReadKey(true);
            //  OrderStatus os;
            //  Enum.TryParse("Delivered", true, out os);
            //  Console.WriteLine(os);
            // OrderStatus orderStatus = Enum.Parse<>();
            // Console.WriteLine("String to Enum");
            // Console.WriteLine("------------");

            //OrderStatus oss = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            //Console.WriteLine(oss);
        }
    }
}
