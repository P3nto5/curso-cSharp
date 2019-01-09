using System;

namespace Hora_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Hora_Inicial = 0, Hora_Final = 0, Hora_Duracao=0 ;
            Console.WriteLine("digite a hora inicial do jogo");
            Hora_Inicial = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a hora final do jogo");
            Hora_Final = int.Parse(Console.ReadLine());

            if (Hora_Inicial < Hora_Final)
            {
                Hora_Duracao = Hora_Final - Hora_Inicial;
            }
            else
            {
                Hora_Duracao = 24 + Hora_Final - Hora_Inicial;
            }
            Console.WriteLine("o jogo durou: "+Hora_Duracao+" horas");
            Console.ReadKey();

        }
    }
}
