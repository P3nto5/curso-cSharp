
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallOs.Entities;
using CallOs.Entities.Enums;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados");
            Console.WriteLine("Nome do estagiario");
            string nomeEst = Console.ReadLine();
            Console.WriteLine("Email");
            string emailEst = Console.ReadLine();
            Console.WriteLine("Numero (99)99999-99999");
            string numEst = Console.ReadLine();
            Console.WriteLine("Codigo do estagiario");
            int codeEst = int.Parse(Console.ReadLine());
            Console.WriteLine("Data de adimissao (dd/mm/yyyy)");
            DateTime DateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Nome do requisitante");
            string nomeReq = Console.ReadLine();
            Console.WriteLine("Codigo do requisitante");
            int codeReq = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the status ->");
            Console.WriteLine("Delivered or Pending or Done");

            Enum.TryParse(Console.ReadLine(), true, out EnumServico status);
            

            Trainee trainee = new Trainee(nomeEst, emailEst, numEst, codeEst, DateTime);
            Requester requester = new Requester(nomeReq, codeReq);
            Ordem ordem = new Ordem(DateTime, status, trainee, requester);

            Console.WriteLine("Quantos serviços voce ira fazer? \n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"O nome do #{i}° serviço");
                string servNome = Console.ReadLine();
                Console.WriteLine($"O #{i}° codigo");
                int servCode = int.Parse(Console.ReadLine());
                int servQuant = n;
                Servicos servico = new Servicos(servNome, servCode, servQuant);
                ordem.AddService(servico);

                Console.WriteLine("Numero de peças que voce vai levar");
                int nPec = int.Parse(Console.ReadLine());
                for (int j = 1; j <= nPec; j++)
                {
                    Console.WriteLine($"O nome da #{j}° peças");
                    string pecNome = Console.ReadLine();
                    Console.WriteLine($"O #{j}° codigo");
                    int pecCode = int.Parse(Console.ReadLine());
                    Console.WriteLine("quantidade do componente");
                    int pecQuant = int.Parse(Console.ReadLine());
                    Peças peças = new Peças(pecNome, pecCode, pecQuant);

                    ordem.AddPecas(peças);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Order sumary");
            Console.WriteLine(ordem);
            Console.ReadKey(true);



        }
    }
}
