using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace calculadoraPOO
{
  
    class main
    {
        
        static void Main(string[] args)
        {
            //instancia as classes
            Calculadora calc = new Calculadora();

            //atribui variaveis
            //variaveis do tipo float
            
            
            
            //variaveis do tipo booleano
            
            //le o primeiro numero
            Console.WriteLine("Digite o primeiro numero");
            calc.verifica = Console.ReadLine();
            //chama o metodo verificaçao de espaço em branco
            calc.numero_1= Verifica(calc.verifica);
           //le o segundo numero
            Console.WriteLine("Digite o segundo numero");
            calc.verifica = Console.ReadLine();
            //chama o metodo verificaçao de espaço em branco
            calc.numero_2 = Verifica(calc.verifica);



            Console.WriteLine("digite o operador \n + para soma \n - para subtraçao \n * multiplicaçao \n / divisao");
             // opcao_verifica = Console.ReadLine();
            calc.opcao += Console.ReadKey(true).Key;
            // opcao = Verifica_Caracter(opcao_verifica);



            if (calc.opcao == "+")
            {
                Console.WriteLine("Resultado da soma");
                Console.WriteLine(calc.soma(calc.numero_1,calc.numero_2));
            }
           
           /* else
            {
                Console.WriteLine(n2.subtraçao(num, num_1));
                Console.WriteLine(n3.multiplicaçao(num, num_1));
                Console.WriteLine(n4.divisao(num, num_1));
            }
            */
            Console.ReadKey(true);
            

        }
        //method de verificaçao
        static double Verifica(string test) {
            //variaveis locais
            double num;
            bool veri;
            //tipo booleano que recebe a string e transforma em float
            veri = double.TryParse(test, out num);
            if (test == " " || test == null || test == "0")
            {
                Console.WriteLine("digite um digito valido");
            }
            //senao se o bool
            else if (veri)
            {
                //o numero a string em double
                num = double.Parse(test);
            }
            //senao mostra menssagem
            else
            {
                Console.WriteLine("caracter invalido");
            }
            //retorna o numero float 
            return num;
        }
        // verifica os foi digitado apenas caracteres especiais, com a funçao lambda, importanto o using linq; 
        public static bool Verifica_Caracter(char ch/*aceitaEspaco*/)
        {
            return !Char.IsLetterOrDigit(ch);
        }
    }
}
