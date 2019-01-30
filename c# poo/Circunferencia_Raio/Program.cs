using System;
using System.Globalization;

namespace Circunferencia_Raio
{
    class Program
    {
        static void Main(string[] args)
        {
            Global G = new Global();
            Console.WriteLine("Digite o raio");
            G.raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            G.Circunferencia(G.raio);
            G.Volume(G.raio);
            Console.WriteLine();
            Console.WriteLine("Dados: "+G);           

            Console.ReadKey(true);

        }
        
    }
}
