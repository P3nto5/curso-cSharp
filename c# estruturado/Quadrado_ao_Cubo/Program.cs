using System;

namespace Quadrado_ao_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero = 0, first = 0 , second = 0, third = 0;
            Console.WriteLine("Digite um numero");
            Numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= Numero; i++)
            {
                first =  i;
                second = i * i;
                third =  i * i * i;

            }
            Console.WriteLine("\n Sequancial: " + first + "\n Quadrado: " + second + "\n Cubo: " + third);

            Console.ReadKey(true);

        }
    }
}
