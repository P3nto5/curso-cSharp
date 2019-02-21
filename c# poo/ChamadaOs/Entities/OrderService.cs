using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ChamadaOs.Entities
{
    class OrderService
    {
        public int Quantity { get; set; }
        public string code { get; set; }
        public Components Components { get; set; }

        public OrderService()
        {

        }

        public OrderService(int quantity, string code, Components components)
        {
            Quantity = quantity;
            this.code = code;
            Components = components;
        }

        
        public int Cont()
        {
            return Quantity;
        }
        public override string ToString()
        {
            return "Quantity of component"
                + Components.QuantyComponent;
                

        }

    }
}
