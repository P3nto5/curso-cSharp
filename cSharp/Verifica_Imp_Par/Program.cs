using System;

namespace Verifica_Imp_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Digite um numero e verifica se e positivo ou negativo");
            Numero = int.Parse(Console.ReadLine());
            if (Numero % 2== 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            Console.ReadKey();
        }
    }
}
