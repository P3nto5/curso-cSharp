using System;

namespace Validaçao_Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            int Senha = 0;
            Console.WriteLine("Digite sua senha: ");
            while (Senha != 2002)
            {
                Senha = int.Parse(Console.ReadLine());
                if (Senha != 2002)
                {
                    Console.WriteLine("Acesso precto, Digite novamente sua senha");
                }
                else
                {
                    break;
                }


            }
            Console.WriteLine("acesso permitido :) ");
            Console.ReadKey(true);
        }
    }
}
