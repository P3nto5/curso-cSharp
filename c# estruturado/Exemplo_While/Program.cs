using System;

namespace Exemplo_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double Numero = double.Parse(Console.ReadLine());

            while (Numero>0.0)
            {
                double raiz = Math.Sqrt(Numero);
                Console.WriteLine(": " + raiz);
                Console.Write("Digite outro numero");
                Numero = double.Parse(Console.ReadLine());
            }
            Console.ReadKey(true);


        }
    }
}
