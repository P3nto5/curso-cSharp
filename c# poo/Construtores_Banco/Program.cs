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
          

            Console.WriteLine("Entre com o numero da conta");
            int numero = int.Parse(Console.ReadLine());
            //Entrada do numero da conta

            Console.WriteLine("Entre com o nome titular da conta");
            string nome = Console.ReadLine();
            //Entrada com o nome do titular da conta

            Console.WriteLine("Deseja depositar");
            string Opçao = Console.ReadLine();
            //Entrada de verificaçao se deseja depositar
            if(Opçao == "sim" || Opçao =="Sim")
            {
                Console.WriteLine("Digite o deposito inicial");
                Double deposito = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                //leitura do deposito
                conta = new Global(numero, nome, deposito);
                //instanciando o objeto e passando por parametro os atributos 
                Console.WriteLine("Dados atualizados: \n" + conta);
                //printando na tela os dados atualizados
                Console.WriteLine("voce deseja depositar novamente ?");                
                string Opçao_Novo_Deposito = Console.ReadLine();
                //segunda verificaçao se deseja depositar novamente
                if (Opçao_Novo_Deposito == "sim" || Opçao_Novo_Deposito =="Sim" )
                {
                    
                    double Nquantia = double.Parse(Console.ReadLine());
                    //leitura da quantia a ser depositada
                    conta.Deposito(Nquantia);
                    //passando o atributo para o set do metodo
                    conta = new Global(numero, nome, deposito);
                    //instanciando o objeto novamente e quem sabe funcionar
                    Console.WriteLine("Dados atualizados: \n" + conta);
                    // atualizando os dados do projeto
                    Console.WriteLine("Digite o quanto deseja sacar");
                    if (conta.VerificaSaldo(Nquantia) == false)//verifica se o saldo e negativo ou a quantia a ser sacada e menor do que se tem em caixa
                    {                        
                        string Opçao_Saque = Console.ReadLine();//leitura para verificar se ocorrera o sague se caso o mesmo passar 
                        if (Opçao_Saque == "sim" || Opçao_Saque == "Sim")
                        {
                            conta = new Global(numero, nome, deposito);
                            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            //leitura para saber quanto sera sacado
                            conta.Saque(saque);
                            //passando o atributo saque por paramentro para o set do metodo
                            Console.WriteLine("dados atualizados: \n" + conta);
                            //dados atualizados
                        }
                        else
                        {
                            conta = new Global(numero, nome);
                            // opçao digitada e nao, entao nao foi realizada modificaçoes
                        }
                    }
                    else
                    {
                        Console.WriteLine(conta.VerificaSaldo(Nquantia));
                        //mensagem do metodo
                    }
                }
                else
                {
                    conta = new Global(numero, nome);
                    //opçao digitada e nao, entao nao foi realizada modificaçoes
                }
            }
            else
            {
               conta = new Global(numero, nome);
                //opçao digitada e nao, entao nao foi realizada modificaçoes
            }

            Console.WriteLine();
            Console.WriteLine("Dados: \n"+conta);          

            Console.ReadKey(true);
        }
    }
}
