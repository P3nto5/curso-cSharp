using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composi;
using Composi.Entities;
using Composi.Entities.Enums;
using System.Globalization;
namespace Composi

    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departament's name");
            string deptname = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your level (Junior/MidLevel/Senior):");
            WorkLevel level;
            Enum.TryParse<WorkLevel>(Console.ReadLine(), true, out level);
            Console.WriteLine("Base salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament departament = new Departament(deptname);
            Worker worker = new Worker(name, level, baseSalary ,departament);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine($"Enter # {i} contract data");
                Console.WriteLine("Date (DD/MM/YYYY)");
                DateTime dateTime = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hour)");
                int hours = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(dateTime, valuePerHour, hours);
                worker.AddContract(hourContract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter the mouth and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name"+worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for"+monthAndYear+": "+worker.Income(year, month));
            Console.ReadKey(true);
        }
    }
}
