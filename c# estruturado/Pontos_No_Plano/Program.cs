using System;

namespace Pontos_No_Plano
{
    class Program
    {
        static void Main(string[] args)
        {
            double x,y;
            Console.WriteLine("Digite o valor do eixo X");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do eixo Y");
            y = double.Parse(Console.ReadLine());

            if (x>0 && y>0)
            {
                Console.WriteLine("Q1");

            } if (x<0 && y>0)
            {
                Console.WriteLine("Q2");
            }
            if (x<0 && y<0)
            {
                Console.WriteLine("Q3");
            }
            if (x>0 && y<0)
            {
                Console.WriteLine("Q4");
            }
            if (x==0 && y==0)
            {
                Console.WriteLine("Origem");
            }

            Console.ReadKey();

        }
    }
}
