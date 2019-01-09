using System;

namespace Intervalo_Verificaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            int i;
            int Quant;
            int cont_IN=0;
            int cont_OUT=0;
            Console.WriteLine("Digite a quantidade de numeros");
            Quant = int.Parse(Console.ReadLine());
            for ( i = 0; i < Quant; i++)
            {
                Console.WriteLine("digite os numeros");
                Numero = int.Parse(Console.ReadLine());

                if (Numero>10 && Numero<20)
                {
                    cont_IN++;
                }
                else
                {
                    cont_OUT++;
                }

            }
            Console.WriteLine();
        }
    }
}
