using System;

namespace Divisiveis_Verificaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Numero: ");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey(true);

        }
    }
}
