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
        public string name { get; set; }
        public Components Components { get; set; }


        public OrderService()
        {

        }

        public OrderService(int quantity, Components components)
        {
            Quantity = quantity;
            Components = components;
        }

        public string ConcT()
        {
            string concat;
            return concat = name + "-" +Quantity;
        }
        public int Cont()
        {
            return Quantity;
        }



        public override string ToString()
        {
            return Components.Name
                + ", "
                + Quantity
                + ", "
                + ConcT().ToString()
                + ", "
                + Cont().ToString();
        }



    }
}
