using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.WriteLine("Enter the number of tax payers");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n  ; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.WriteLine("Individual or company (i/c)");
                char type = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Anuel income");
                double income = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.WriteLine("Health expenditures; ");
                    double healthExp = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, healthExp));
                }
                else
                {
                    Console.WriteLine("Number of employee");
                    int numberOfEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEmployee));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES Paid");
            foreach (TaxPayer tp  in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax);
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum);
            Console.ReadKey(true);
        }
        
    }
}
