using System;
using System.Globalization;
using Shopping.Entities;
using Shopping.Entities.Enums;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the data");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("birth date (DD/MM/YYYY)");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.WriteLine("Status ");
            Console.WriteLine(" Pending_Payment ");
            Console.WriteLine(" Processing ");
            Console.WriteLine(" Shipped ");
            Console.WriteLine(" Delivered ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), true,out status);

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to the order");
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item date ");
                Console.WriteLine("Product name ");
                string productName = Console.ReadLine();

                Console.WriteLine(" Product price ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.WriteLine("Quantity ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);                
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY ");
            Console.WriteLine(order);
            Console.ReadKey(true);
        }
    }
}
