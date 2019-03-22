using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComparassionT.Entities;

namespace ComparassionT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Notebook", 1900.00));
            list.Add(new Product("Tablet", 450.00));
            list.Add(new Product("ablet", 650.00));

           
            list.Sort((p1, p2)  => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()))  ;

            foreach (Product prod in list)
            {
                Console.WriteLine(prod);
            }
            Console.ReadKey(true);
        }
        
    }
}
