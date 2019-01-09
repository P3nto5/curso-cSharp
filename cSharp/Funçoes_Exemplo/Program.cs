using System;

namespace Funçoes_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("O maior: "+resultado);
            Console.ReadKey(true);
        }
        static int Maior(int a,int b, int c)
        {
            int Resultado = 0;
            if (a>b && a>c)
            {
                Resultado = a;
            }
            else if (b > c)
            {
                Resultado = b;
            }
            else
            {
                Resultado = c;
            }

            return Resultado;
        }
    }
}
