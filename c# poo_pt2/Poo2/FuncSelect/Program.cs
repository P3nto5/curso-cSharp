using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncSelect.Entities;
using System.Globalization;

namespace FuncSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mousse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("Hd Case", 80.90));

            //Func<Product, string> func = p => { return p.Name.ToUpper(); };
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey(true);
        }
    }
}
