using System;

namespace Gasolina_Verificaçao
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op=0;
            int cont_Alcool = 0;
            int cont_Gasolina = 0;
            int cont_Diesel = 0;
            Console.WriteLine("Digite a Opçao ");
            Console.WriteLine("1--Alcool");
            Console.WriteLine("2--Gasolina");
            Console.WriteLine("3--Diesel");

            while (Op!=4)
            {
                if (Op == 1)
                {
                    cont_Alcool++;
                }
                else if (Op==2)
                {
                    cont_Gasolina++;
                }
                else if(Op==3)
                {
                    cont_Diesel++;
                }
                Op = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Quantidade de votos em Alcool: "+cont_Alcool);
            Console.WriteLine("Quantidade de votos em Gasolina: "+cont_Gasolina);
            Console.WriteLine("Quantidade de votos em Diesel: "+cont_Diesel);
            Console.ReadKey(true);
        }
    }
}
