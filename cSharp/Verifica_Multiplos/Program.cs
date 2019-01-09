using System;

namespace Verifica_Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;

            Console.WriteLine("Digite dois numeros");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            if ((A%B)==0 || (B%A)==0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("nao sao multiplos");
            }
            Console.ReadKey();
        }
    }
}
