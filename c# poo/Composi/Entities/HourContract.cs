using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composi;
using Composi.Entities;
using Composi.Entities.Enums;

namespace Composi.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            this.valuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * valuePerHour;
        }
    }
}
