using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace Calc_Static
{
    class Global
    {
        public Double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
         public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
