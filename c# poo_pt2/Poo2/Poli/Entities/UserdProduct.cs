using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Poli.Entities
{
    class UserdProduct : Product
    {
        public  DateTime ManuFactureDate { get; set; }

        public UserdProduct()
        {
        }

        public UserdProduct(string name, double price, DateTime manuFactureDate)
        :base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }
        public override string priceTag()
        {
            return Name
                + "(used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(ManuFacture date: "
                + ManuFactureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
