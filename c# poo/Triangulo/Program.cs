using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Global G = new Global();

            Console.WriteLine("Entre com a largura do retangulo: ");
            G.Largula = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura do retangulo");
            G.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine("Resultado"+G);

            Console.ReadKey(true);
        }
    }
}
