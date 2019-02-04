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
                    Console.WriteLine("Digite o valor a ser depositado ");
                    double Nquantia = double.Parse(Console.ReadLine());
                    //leitura da quantia a ser depositada
                    conta.Deposito(Nquantia);
                    //instanciando o objeto novamente e quem sabe funcionar
                    Console.WriteLine("Dados atualizados: \n" + conta);
                    // atualizando os dados do projeto
                    Console.WriteLine("Voce deseja sacar ?");
                    string Opçao_Saque = Console.ReadLine();
                    if (Opçao_Saque == "sim") {

                        Console.WriteLine("Digite o quanto deseja sacar");
                        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        //conta.Saque(saque);
                        if (conta.VerificaSaldo(saque) == false){//verifica se o saldo e negativo ou a quantia a ser sacada e menor do que se tem em caixa                        {

                            conta.Saque(saque);
                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");
                            
                        }
                    }
                    else
                    {
                       conta = new Global(numero, nome, deposito);
                        //opçao digitada e nao, entao nao foi realizada modificaçoes                     

                    }
                }
                else
                {
                    Console.WriteLine("Voce deseja sacar esse deposito ?");
                    string Opçao_Saque_novamente = Console.ReadLine();
                    if (Opçao_Saque_novamente == "sim")
                    {

                        Console.WriteLine("Digite o quanto deseja sacar: ");
                        double saque_novamente = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        //conta.Saque(saque);
                        if (conta.VerificaSaldo(saque_novamente) == false)
                        {//verifica se o saldo e negativo ou a quantia a ser sacada e menor do que se tem em caixa                        {

                            conta.Saque(saque_novamente);                          

                        }
                        else
                        {
                            Console.WriteLine("Saldo insuficiente");

                        }
                                                 
                    }
                    else
                    {                        
                          conta = new Global(numero, nome, deposito);
                        //opçao digitada e nao, entao nao foi realizada modificaçoes                     

                    }                    
                }
            }
            else
            {
               conta = new Global(numero, nome);
                //opçao digitada e nao, entao nao foi realizada modificaçoes
              
            }           
            Console.WriteLine();
            Console.WriteLine("Dados finais: " + conta);
            Console.ReadKey(true);
        }
    }
}
