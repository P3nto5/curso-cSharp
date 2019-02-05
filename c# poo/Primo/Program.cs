using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, cont=0;
            Console.WriteLine("Digite um numero");
            num = double.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num%i ==0)
                {
                    cont++;
                }
                

               
            }
            if (cont == 2)
            {
                Console.WriteLine("O numero " + num + " e primo ");
            }
            else
            {
                Console.WriteLine("Nao e primo");
            }
            Console.ReadKey(true);
        }
    }
}
