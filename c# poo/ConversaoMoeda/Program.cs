using System;
using System.Globalization;

namespace ConversaoMoeda
{
    class Program
    {
        static double Dolar;
        static double Reais;

        static void Main(string[] args)
        {
            Global cot = new Global();

            Console.WriteLine("Qual  Cotaçao do dolar: ");
            Dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );

            Console.WriteLine("Quantidade de dolares que vai comprar: ");
            cot.Quantidade = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.WriteLine("Valor a ser pago em reais: "+cot.ValorPago(Dolar, cot.Quantidade).ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey(true);
        }
    }
}
