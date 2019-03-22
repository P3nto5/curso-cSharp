using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQQ1.Entities;


namespace LINQQ1
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> colletion)
        {
            Console.WriteLine(message);
            foreach (T obj in colletion)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { id = 1, name = "Tools", tier = 2 };
            Category c2 = new Category() { id = 2, name = "Computers", tier = 1 };
            Category c3 = new Category() { id = 3, name = "Electronics", tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() {Id =1, Name = "Computer", Price = 1100.0, category = c2},
                new Product() {Id =2, Name = "Hammer", Price = 11.0, category = c1},
                new Product() {Id =3, Name = "Tv", Price = 1500.0, category = c3},
                new Product() {Id =4, Name = "Notebook", Price = 900.0, category = c2},
                new Product() {Id =5, Name = "Saw", Price = 80.0, category = c1},
                new Product() {Id =6, Name = "Tablet", Price = 500.0, category = c2},
                new Product() {Id =7, Name = "Camera", Price = 300.0, category = c3},
                new Product() {Id =8, Name = "Printer", Price = 400.0, category = c3},
                new Product() {Id =9, Name = "MacBook", Price = 5100.0, category = c2},
                new Product() {Id =10, Name = "Sound bar", Price = 700.0, category = c3},
                new Product() {Id =11, Name = "Level", Price = 70.0, category = c1 }
            };
            var v1 = products.Where(p => p.category.tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900", v1);

            var r1 = products.Where(p => p.category.name == "Tools").Select(p => p.Name);
            Print("Names of products from tools", r1);

            var s1 = products.Where(p => p.Name[0] == 'C').Select( p => new {ProductName = p.Name, ProductPrice = p.Price, CategoryName = p.category.name});
            Print("NAMES STARTER WITH 'C' AND ANONNYMOYS OBJECT", s1);

            var s2 = products.Where(p => p.category.tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY THEN BY NAME", s2);

            var s3 = s2.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", s3);

            var s4 = products.First();
            Console.WriteLine(s4);
            var s5 = products.Where(p => p.Price > 5000.0).First();
            Console.WriteLine("Dirst teste2: "+ s5);

            Console.WriteLine();
            var s6 = products.FirstOrDefault();
            Console.WriteLine(" First or default"+s4);
            var s7 = products.Where(p => p.Price > 8000.0).FirstOrDefault();
            Console.WriteLine(" first or default maior que 5000: " + s5);

            Console.WriteLine();
            var s8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + s8);
            var s9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + s9);

            Console.WriteLine();
            var s10 = products.Max(P => P.Price);
            Console.WriteLine("Max price: " + s10);
            var s11 = products.Min(P => P.Price);
            Console.WriteLine("Min price: " + s11);

            Console.WriteLine();
            var s12 = products.Where(p => p.category.id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 sum prices: "+  s12);
            var s13 = products.Where(p => p.category.id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 avarage prices: " + s13);
            var s14 = products.Where(p => p.category.id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 default or empty prices: " + s14);


            Console.ReadKey(true);
            
        }
    }
}
