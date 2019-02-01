using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Construtores_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Global conta;
            Double quantia;

            Console.WriteLine("Entre com o numero da conta");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta");
            string nome = Console.ReadLine();

            Console.WriteLine("Deseja depositar");
            string Opçao = Console.ReadLine();

            if(Opçao == "Sim" || Opçao =="sim")
            {
                Console.WriteLine("Digite o deposito inicial");
                Double deposito = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new Global(numero, nome, deposito);

                Console.WriteLine("voce deseja depositar novamente ?");
                
                string Opçao_New = Console.ReadLine();
                if (Opçao_New == "Sim" || Opçao_New != "nao")
                {
                    double Nquantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta.Deposito(Nquantia);
                    Console.WriteLine("Dados atualizados: \n" + conta);

                    Console.WriteLine("Digite o quanto deseja sacar");
                    if (conta.VerificaSaldo(Nquantia) == false)
                    {
                        string Opçao_Saque = Console.ReadLine();
                        if (Opçao_Saque == "Sim" || Opçao_Saque == "sim")
                        {
                            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            conta.Saque(saque);
                            Console.WriteLine("dados atualizados: \n" + conta);
                        }
                        else
                        {
                            conta = new Global(numero, nome);
                        }
                    }
                }
                else
                {
                    conta = new Global(numero, nome);
                }
            }
            else
            {
               conta = new Global(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados: \n"+conta);          

            Console.ReadKey(true);
        }
    }
}
