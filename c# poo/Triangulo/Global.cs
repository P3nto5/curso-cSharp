using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Triangulo
{
    

    class Global
    {
        public double Largula;
        public double Altura;

        public Double Area()
        {
            double result;
            return result = Largula * Altura;
        }
        public Double Perimetral()
        {
            double result;
            return result = 2 * (Largula + Altura);
        }
        public Double Diagonal()
        {
            double  diagonal;
            diagonal = Math.Sqrt(Largula) + Math.Pow(Altura, 2);
            return diagonal; 
        }

        public override string ToString()
        {
            return Largula.ToString("F2",CultureInfo.InvariantCulture)
                + " :  "
                +Altura.ToString("F2",CultureInfo.InvariantCulture)   
                + " : "
                +"\n"
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                +"\n"
                +Perimetral().ToString("F2",CultureInfo.InvariantCulture)
                +"\n"
                + Diagonal().ToString("F2", CultureInfo.InstalledUICulture);
                
                

        }
    }
}
