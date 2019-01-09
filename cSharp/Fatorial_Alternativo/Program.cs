using System;

namespace Fatorial_Alternativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat, n;
            Console.WriteLine("Numero");
            n = int.Parse(Console.ReadLine());
            for(fat =1; n>1; n--)
            {
                fat = fat * n;
            }
            if (fat == 0 || fat==1)
            {
                Console.WriteLine("Sem fatorial");
            }
            else if (fat<0)
            {
                Console.WriteLine("sem fatorial de numero negativo");
            }
            else
            {
                Console.WriteLine(fat);
            }
            
            Console.ReadKey(true);
        }
    }
}
