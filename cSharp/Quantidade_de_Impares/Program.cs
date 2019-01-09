using System;

namespace Quantidade_de_Impares
{
    class Program
    {
        static void Main(string[] args)
        {

            int Numero=0 , i=0 ;
            Console.WriteLine("Digite um numero: ");
            Numero = int.Parse(Console.ReadLine());
            for (i = 0; i <Numero ; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);



            

        }
    }
}
