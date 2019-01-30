using System;

namespace Fatorial_Verificaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,fat=1,numero_temp= 1 ;
            Console.WriteLine("Digite o numero");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                fat *= n--;
            }
            Console.WriteLine(fat);
            Console.ReadKey(true);


           
        }
    }
}
