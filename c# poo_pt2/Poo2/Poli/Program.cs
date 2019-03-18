using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poli.Entities;
using System.Globalization;


namespace Poli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the number os products");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n ; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.WriteLine("Coomon, used or imported (c/u/i)");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if(ch == 'u')
                {
                    Console.WriteLine("ManuFacture Date (DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UserdProduct(name, price, date));
                }
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.priceTag());
            }
            Console.ReadKey(true);
        }
    }
}
