using System;

namespace Quadrante_Verificaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0, Y = 0;
            Console.WriteLine("Digite a Coordenada X, e a Y");
             X = int.Parse(Console.ReadLine());
             Y = int.Parse(Console.ReadLine());
            while (X!=0 && X!=0)
            {

                if(X>0 && Y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if (X < 0 && Y > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                 else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Terceiro quadrante");
                }
                else if (X>0 && Y < 0)
                {
                    Console.WriteLine("Quarto quadrante");
                }
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Origem Digitada");
            Console.ReadKey(true);

        }
    }
}
