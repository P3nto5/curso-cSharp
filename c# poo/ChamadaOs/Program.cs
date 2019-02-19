using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamadaOs.Entities;
using ChamadaOs.Entities.Enums;
namespace ChamadaOs
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
            Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Year of entry (DD/MM/YYYY) ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.WriteLine(" Status ");
            Console.WriteLine(" Delivered ");
            Console.WriteLine(" Pending ");
            Console.WriteLine(" done ");
            
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), true, out status);

            Client client = new Client(name, email, cpf, dateTime);
            Ordercs order = new Ordercs(DateTime.Now, status, client);

            Console.WriteLine("How many services to the order");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} service date");
                Console.WriteLine("Service name");
                string servicename = Console.ReadLine();

                Console.WriteLine("Code of service");
                string code = Console.ReadLine();

                Console.WriteLine("Date of exit");
                DateTime date_Exit = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Date of return");
                DateTime date_Return = DateTime.Parse(Console.ReadLine());

                Components components = new Components(name, code);

                Console.WriteLine("Quantity");
                int quantity = int.Parse(Console.ReadLine());

                OrderService orderService = new OrderService(quantity, code, components);
                order.AddItem(orderService);

            }
            Console.ReadKey(true);
            


        }
    }
}
