using System;
using System.Globalization; 


namespace Calc_Static
{
    class Program
    {
        static Double Raio;
 
        static void Main(string[] args)
        {

            Global calc = new Global();

            Console.WriteLine("Digite o raio");
            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circunferencia: " + calc.Circunferencia(Raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + calc.Volume(Raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey(true);
        }
    }
}
