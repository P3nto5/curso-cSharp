using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Pensao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,cont;
            Console.WriteLine("Digite quantos alunos voce vai receber");
            n = int.Parse(Console.ReadLine());

            
            Pensao[] vect = new Pensao[n];
            Pensao veri = new Pensao();

            for (int i = 0; i < 9; i++)
            {
               // Console.WriteLine("Digite o nome do "+(i+1)+" Aluno");
               // string nome = Console.ReadLine();

               // Console.WriteLine("Digite o email do " + (i + 1) + " Aluno");
               // string email = Console.ReadLine();

                Console.WriteLine("Digite qual o numero do quarto de 0 a 9");
                int quarto = int.Parse(Console.ReadLine());

                vect[i] = new Pensao {  Number = quarto };
                
                     if (vect[i].quartovago(quarto) == true && quarto!= i )
                     {
                         Console.WriteLine("quarto ja ocupado");
                         Console.WriteLine("Digite um numero de quarto nao ocupado");
                         int quarto_vago = int.Parse(Console.ReadLine());
                         vect[i] = new Pensao {  /*Name = nome, Email = email,*/ Number = quarto_vago };
                     }   
                     else
                     {
                         Console.WriteLine("Quarto liberado");               
                     }                
            }
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("O nome do estudante e: "+vect[i].Name);
                //Console.WriteLine("O email do estudante e: "+vect[i].Email);
                Console.WriteLine("O quarto do estudante e: "+vect[i].Number);
                Console.WriteLine("\n");

            }
            Console.ReadKey(true);

        }
    }
}
