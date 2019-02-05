using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Pensao
{
    class Pensao
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }

        public bool quartovago(int numero)
        {
            if (Number == numero)
            {
                return true;
            }
            return false;
        }
        public bool PrimeiroQuarto(int numero)
        {
            if (numero==0)
            {
                return true;
            }
            return false;
        }
            
    }
}
