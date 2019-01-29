using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Circunferencia_Raio
{
    class Global
    {
        public Double raio;
        public Double Pi = 3.14;


        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);

        }
        public override string ToString()
        {
            return raio.ToString("F1", CultureInfo.InvariantCulture)
                + "\n "
                + "Circunferencia: "
                + Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Volume: "
                + Volume(raio).ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + "Pi: "
                + Pi.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
