using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
     

        static void Main(string[] args)
        {
            var Numero_1 = 0.0;
            var Numero_2 = 0.0;
            var Resultado = 0.0;
            var Opcao="";


            Console.WriteLine("Digite o primeiro numero \n");
            Numero_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a Operaçao \n");
            Console.WriteLine("Soma -->: +");
            Console.WriteLine("Subtração -->: -");
            Console.WriteLine("Multiplicação -->: * ");
            Console.WriteLine("Divisão -->: / ");
            Console.WriteLine("Mod -->: %");
            Console.WriteLine("Potenciação -->: ^ ");

            Opcao = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero \n");
            Numero_2 = double.Parse(Console.ReadLine());

            if (Opcao == "+")
            {
                Resultado = Numero_1 + Numero_2;
                Console.WriteLine("Resultado: "+Resultado);
            }
            if (Opcao == "-")
            {
                Resultado = Numero_1 - Numero_2;
                Console.WriteLine("Resultado: "+Resultado);
            }
            if (Opcao == "*")
            {
                Resultado = Numero_1 * Numero_2;
                Console.WriteLine("Resultado: "+Resultado);
            }
            if (Opcao == "/")
            {
                Resultado = Numero_1 / Numero_2;
                Console.WriteLine("Resultado: "+Resultado);
            }
            if (Opcao == "%")
            {
                Resultado = Numero_1 % Numero_2;
                Console.WriteLine("Resuldado: "+Resultado);
            }
            if (Opcao == "^")
            {
                Resultado = Math.Pow(Numero_1, Numero_2);
                Console.WriteLine("Resultado: "+Resultado);
            }
            else
            {
                Console.WriteLine("Opçao incorreta");
            }

            Console.ReadKey(true);


        }

    }
}
