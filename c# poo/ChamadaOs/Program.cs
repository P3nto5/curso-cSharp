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
        private static Components component;

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
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} service date");
                Console.WriteLine("Service name");
                string serviceName = Console.ReadLine();

                Console.WriteLine("Code of service");
                string serviceCode = Console.ReadLine();
                
                Console.WriteLine("Quantity component");
                int quantityComponent = int.Parse(Console.ReadLine());
                for (int j = 0; j < quantityComponent; j++)
                {
                    Console.WriteLine("Name of component");
                    string componentname = Console.ReadLine();

                    Console.WriteLine("Quantity of this component");
                    int quantityComponents = int.Parse(Console.ReadLine());

                    Console.WriteLine("Code of this component");
                    string codeComponents = Console.ReadLine();

                    Components component = new Components(componentname, codeComponents, quantityComponents);
                    order.AddComponent(component);
                    
                }

                Console.WriteLine("Hour(HH:mm:ss) of exit");
                DateTime date_Exit = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Hour(HH:mm:ss) of return");
                DateTime date_Return = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Quantity");
                int quantity = int.Parse(Console.ReadLine());

                Service service = new Service(serviceName, serviceCode, date_Exit, date_Return);
                Console.WriteLine("Status of service");
                Console.WriteLine(service);

                OrderService orderService = new OrderService(quantity, serviceCode, component);
                order.AddItem(orderService);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY ");
            Console.WriteLine(order);
            Console.ReadKey(true);



        }
    }
}
