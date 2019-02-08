using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Pensao_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite Quantos aluno irao alegar quarto");
            int nAlunos = int.Parse(Console.ReadLine());   
            Pensao[] vetAlunos = new Pensao[nAlunos];           
            for (int i = 0; i < nAlunos; i++)
            {
               // Console.WriteLine("Digite o nome do aluno");
                //string nome = Console.ReadLine();
                Console.WriteLine("Digite o quarto do "+(i+1)+"° aluno");
                int nQuarto = int.Parse(Console.ReadLine());

                if (nQuarto>0 || nQuarto<10)
                {
                    Console.WriteLine("QUARTO DESOCUPADO");
                }
                else
                {
                    Console.WriteLine("Quarto ocupado");
                    Console.WriteLine("Digite um numero de quarto valido");
                    int nQuarto_vago = int.Parse(Console.ReadLine());

                }

            }
            for (int i = 0; i < nAlunos; i++)
            {
                Console.WriteLine(vetAlunos[i].numberRoom);
                
            }
            Console.ReadKey(true);
        }
    }
}
