using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Call.Entities;
using Call.Entities.Enums;
namespace Call
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the data");
            Console.WriteLine("name of trainee: ");
            string NameTrainee = Console.ReadLine();
            Console.WriteLine("Email of trainee");
            string Email = Console.ReadLine();
            Console.WriteLine("Date of entry (dd/mm/yyyy)");
            DateTime DateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("enter the status ->");
            Console.WriteLine(" Status ");
            Console.WriteLine(" Delivered ");
            Console.WriteLine(" Pending ");
            Console.WriteLine(" Done ");

            Enum.TryParse(Console.ReadLine(), true, out OrderStatus status);

            Trainee trainee = new Trainee(NameTrainee, Email, DateTime);
            Order ord = new Order(DateTime.Now, status, trainee);

            Console.WriteLine("How many services to the order");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} service date");
                Console.WriteLine("Service name");
                string serviceName = Console.ReadLine();

                Console.WriteLine("Code of service");
                string serviceCode = Console.ReadLine();
               

                Service serv = new Service(serviceName, serviceCode, n);

                OrderService orderService = new OrderService(serv, n);
                ord.AddService(orderService);
            }
            Console.WriteLine("Quantity of components");
            int qComponents = int.Parse(Console.ReadLine());
            for (int j = 1; j <= qComponents; j++)
            {
                Console.WriteLine($"Name {j}° component ");
                string nameComp = Console.ReadLine();

                Console.WriteLine($"Code  {j}° component");
                string codeComp = Console.ReadLine();

                Console.WriteLine("Quantity of especific component");
                int qComponents_exp = int.Parse(Console.ReadLine());

                Components component = new Components(nameComp, codeComp, qComponents_exp);
                ord.AddComponent(component);
            }

            Console.WriteLine();
            Console.WriteLine("Order sumary");
            Console.WriteLine(ord);
            Console.ReadKey(true);

        }
    }
}
