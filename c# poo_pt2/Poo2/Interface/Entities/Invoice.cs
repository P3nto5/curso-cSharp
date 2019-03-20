using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice()
        {
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment
        {
            get
            {
                return BasicPayment + Tax;
            }
        }
        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment
                + "\n Tax: "
                + +Tax
                + "\n Total payment: "
                + TotalPayment;
        }

    }
}
