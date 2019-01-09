using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            char op;
            double n2;
            int opcao=0;
            Console.WriteLine("estrutura condicionais");
            Console.WriteLine("digite um numero inteiro");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou: "+n1);
            Console.WriteLine("digite um caracter");
            op = char.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou: " + op);
            Console.WriteLine("digite um numero real");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("voce digitou: " + n2);
            Console.WriteLine("--condicionais--");
            Console.WriteLine("\n digita opçao 1 para saber se o numero e impar ou par");
            Console.WriteLine("\n digite opçao M ou F para saber se e masculino ou feminino");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    if (n1 % 2 == 0)
                    {
                        Console.WriteLine("numero par");
                    }
                    else
                    {
                        Console.WriteLine("numero impar");
                    }
                    break;
                case 2:
                    if (op=='F'||op=='f')
                    {
                        Console.WriteLine("feminino");
                    }
                    else
                    {
                        Console.WriteLine("macho");
                    }
                    break;
                default:
                    Console.WriteLine("nenhuma das opçoes acima");
                    break;
            }
            Console.ReadKey(true);
            /*
            */

        }
    }
}
