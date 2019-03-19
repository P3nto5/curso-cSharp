using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using Account.Entiities.Exception;
using Account.Entiities;
namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Holder: ");
            string holder = Console.ReadLine();
            Console.WriteLine("Initial balance: ");
            double initBal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Withdraw limit: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            account acc = new account(number, holder, initBal, withdraw);
            Console.WriteLine();
            Console.WriteLine("Enter amount for withdraw");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
                acc.withdraw(amount);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error format"+ e.Message);
            }
            catch(DomainExceptino e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey(true);
        }
    }
}
