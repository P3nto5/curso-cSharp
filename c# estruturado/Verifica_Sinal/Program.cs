using System;

namespace Verifica_Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Digite um numero e verifica se e positivo ou negativo");
            Numero = int.Parse(Console.ReadLine());
            if (Numero>0)
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
            Console.ReadKey();

        }
    }
}
