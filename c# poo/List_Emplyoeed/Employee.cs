using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace List_Emplyoeed
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void increaseSalary(double percentage)
        {
            Salary = Salary * (percentage / 100);
        }
        public override string ToString()
        {
            return "Id: \n" + Id
                + "Name: \n"
                + Name
                +"Salary: \n"
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
                

        }
    }
}
