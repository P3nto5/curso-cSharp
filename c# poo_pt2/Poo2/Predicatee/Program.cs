using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Predicatee.Entities;
using System.Globalization;

namespace Predicatee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("cd", 50.00));
            list.Add(new Product("cvc", 800.00));
            list.Add(new Product("hd", 500.00));

            list.RemoveAll(ProductTest);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey(true);
        }
        public static bool ProductTest(Product p)
        {
            return  p.Price >= 100.0;
        }
    }
}
