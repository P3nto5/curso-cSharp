using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhering.Entites
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
            
        }

        public BusinessAccount(int number, string holder, double balance, double leonLimit) 
            :base(number, holder, balance)
        {
            LoanLimit = leonLimit;
        }

        public void loan(double amounth)
        {
            if(amounth <= LoanLimit)
            {
                Balance += amounth;
            }
        }
    }
}
