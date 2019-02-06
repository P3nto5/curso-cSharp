using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_Parametros_Atrinuto
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = Calculator.Sum(2,3);
            Console.WriteLine(soma);
            Console.ReadKey(true);
        }
    }
}
