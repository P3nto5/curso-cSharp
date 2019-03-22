using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQ1.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category category { get; set; }

        /* public Product()
         {
         }

         public Product(int id, string name, double price)
         {
             Id = id;
             Name = name;
             Price = price;
         }
         */
        public override string ToString()
        {
            return "Id: " + Id
                + ", Name: " + Name
                + ", Price: " + Price.ToString("F2")
                + ", Category name: " + category.name
                + ", Category tier: " + category.tier;

        }
    }
}
