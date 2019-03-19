using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaArqui.Entities
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        public int quanty { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, int quanty)
        {
            this.name = name;
            this.price = price;
            this.quanty = quanty;
        }
        public double Total()
        {
            return price * quanty;
        }
    }
}
