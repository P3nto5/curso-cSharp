using System;

namespace Conversao_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            double resultado = ((double) a / b);

            //double a;
            //float b;

            //a = 5.1;
            //b = (float)a;
            //b = (int)a;



            //Console.WriteLine(b);
            Console.WriteLine(resultado);
            Console.ReadKey(true);
        }
    }
}
