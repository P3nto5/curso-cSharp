using System;
using System.Globalization;

namespace Static_Circunferencia
{
    class Program
    {
       public static Double Pi = 3.14;
       public static Double Raio;

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o raio");
            Raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferencia: "+Circunferencia(Raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: "+Volume(Raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: "+Pi.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey(true);
        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
