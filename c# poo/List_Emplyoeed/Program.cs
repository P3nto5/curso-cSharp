using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace List_Emplyoeed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered?");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <=n ; i++)
            {
                Console.WriteLine("Employee #"+(i)+":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null) 
            {
                Console.Write("Enter the percentage");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("this Id doesn't exist! ");
            }

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey(true);
        }
    }
}
