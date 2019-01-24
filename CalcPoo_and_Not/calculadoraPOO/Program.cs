using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace calculadoraPOO
{
    class Soma
    {
        public double soma(double n1,double n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;
        }
    }
    class Subtraçao
    {
        public double subtraçao(double n1,double n2)
        {
            double resultado;
            resultado = n1 - n2;
            return resultado;
        }
    }
    class Multiplicaçao
    {
        public double multiplicaçao(double n1, double n2)
        {
            double resultado;
            resultado = n1 * n2;
            return resultado;
        }
    }
    class Divisao
    {
        public double divisao(double n1, double n2)
        {
            double resultado;
            resultado = n1 / n2;
            return resultado;
        }
    }
    /*class Operadores
    {
        public double operadores(string opera)
        {
            
        }
    }
    */
    class main
    {

        static void Main(string[] args)
        {
            //instancia as classes
            Soma n1 = new Soma();
            Subtraçao n2 = new Subtraçao();
            Multiplicaçao n3 = new Multiplicaçao();
            Divisao n4 = new Divisao();

            //atribui variaveis
            //variaveis do tipo float
            var num = 0.0;
            var num_1 = 0.0;
            var returno = 0.0;
            // variaveis do tipo string
            var opcao = "";
            
            string verifica ;
            //variaveis do tipo booleano
            bool opcao_veri;
            bool vell;
            //le o primeiro numero
            Console.WriteLine("Digite o primeiro numero");
            verifica = Console.ReadLine();
            //chama o metodo verificaçao de espaço em branco
            num = Verifica(verifica);
           //le o segundo numero
            Console.WriteLine("Digite o segundo numero");
            verifica = Console.ReadLine();
            //chama o metodo verificaçao de espaço em branco
            num_1 = Verifica(verifica);



            Console.WriteLine("digite o operador \n + para soma \n - para subtraçao \n * multiplicaçao \n / divisao");
             // opcao_verifica = Console.ReadLine();
            opcao += Console.ReadKey(true).Key;
             // opcao = Verifica_Caracter(opcao_verifica);
           
        

            if (opcao == "+")
            {
                Console.WriteLine("Resultado da soma");
                Console.WriteLine(n1.soma(num, num_1));
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
