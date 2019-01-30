using System;
using System.Globalization;

namespace TiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.56;
            string nome = "maria";

            //Console.WriteLine("BOM DIA \n");
            //Console.WriteLine("BOA TARDE");
            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo);
            //Console.WriteLine(nome);
            //Console.WriteLine(saldo.ToString("F2"));
            // Console.WriteLine(saldo.ToString("F4"));
            // Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture));
            // Console.WriteLine("{0} tem {1} anos e tem saldo a {2} reais", nome, idade, saldo);
            //  Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome+" Tem "+idade+" anos e tem saldo igual "+saldo.ToString("F2")+" reais ");
            Console.ReadKey(); 

        }
    }
}
