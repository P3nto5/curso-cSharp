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
            Console.WriteLine("Status ");
            Console.WriteLine(" Pending_Payment ");
            Console.WriteLine(" Processing ");
            Console.WriteLine(" Shipped ");
            Console.WriteLine(" Delivered ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), true, out status);

            Client client = new Client(name, email, cpf, dateTime);
            Ordercs order = new Ordercs(DateTime.Now, status, client);

            Console.WriteLine("How many services to the order");
            


        }
    }
}
