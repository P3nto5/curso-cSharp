using System;

namespace Intervalo_Entre
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor;
            Console.WriteLine("digite o valor");
            Valor = double.Parse(Console.ReadLine());
            if(Valor>25 && Valor<50 )
            {
                Console.WriteLine("dentro do intervalo de 25 e 50");
            }
                else if(Valor>0 && Valor<25)
            {
                Console.WriteLine("dentro do intervalo de 0 e 25");

            }
                else if(Valor>75 && Valor<100)
            {
                Console.WriteLine("dentro do intervalo de 75 e 100");
            }
                 else
            {
                Console.WriteLine("fora do intervalo");
            }

            Console.ReadKey();

        }
    }
}
