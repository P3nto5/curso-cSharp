using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account.Entiities.Exception;

namespace Account.Entiities
{
    class account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double withdrawLimit { get; set; }

        public account()
        {
        }

        public account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            this.withdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {

            Balance += amount;
        }
        public void withdraw(double amount)
        {
            if (amount>withdrawLimit)
            {
                throw new DomainExceptino("maior que o limite");
            }
            if (amount > Balance)
            {
                throw new DomainExceptino("maior que o saldo");
            }
            Balance -= amount;
        }
    }
}
