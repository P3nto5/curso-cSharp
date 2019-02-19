using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inhering.Entites;
namespace inhering
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob", 100.0, 500.0);
            Console.WriteLine(account.Balance);

            Console.ReadKey(true);
        }
    }
}
