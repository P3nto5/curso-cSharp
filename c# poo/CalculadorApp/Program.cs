using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            int linha = 0, coluna = 0, resultado = 0;
            Numero = int.Parse(Console.ReadLine());
            for ( linha = 1; linha <=Numero ; linha++)
            {
                Console.WriteLine("tabuada de: "+linha);
                for (coluna = 1; coluna <=10; coluna++)
                {
                    resultado= linha*coluna;
                    Console.WriteLine(linha+" x "+coluna+"=="+resultado);
                }
            }
            Console.ReadKey(true);

        }
    }
}
