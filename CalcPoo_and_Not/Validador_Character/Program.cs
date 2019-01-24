using System;
using System.Text.RegularExpressions;

namespace Validador_Character
{
    class Program
    {
        static void Main(string[] args)
        {

            var opçao = "";
            var Numero = 0.0;
            Console.WriteLine("Digite um caracter mas tente forçar com: \n palavras e numeros");
            opçao = Console.ReadLine();
            if (Verifica(opçao) == true && Vazio(opçao) == false  )
            {
                Console.WriteLine("digite um numero");
                Numero = double.Parse(Console.ReadLine());
                if(SomentoNumero(opçao, Numero) == false)
                {
                    Console.WriteLine(Numero);
                }
                else
                {
                  Console.WriteLine("nao respeita os requisitos");
                }


            }
            else
            {
                Console.WriteLine("digite um caracter certo");
                Verifica(opçao);
                opçao = Console.ReadLine();
            }

            Console.ReadKey(true);


        }
        public static bool Verifica(string s)
        {

            bool existeCaracterEspecial = Regex.IsMatch(s, (@"[^a-zA-Z0-9]"));
            return existeCaracterEspecial;

        }
        public static bool Vazio(string s)
        {
            if (string.IsNullOrEmpty(s) && string.IsNullOrWhiteSpace(s) && VerificaString(s))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static bool SomentoNumero(string s, double n)
        {
            string linhaArquivo = s;
            string texto = linhaArquivo;
            double numero = n;
       
            if (double.TryParse(texto, out numero))
                return true;
            else
                return false;
                
        }
        public static bool VerificaString(string str)
        {
            char[] c = str.ToCharArray();
            char le = ' ';
            for (int cont = 0; cont < c.Length; cont++)
            {
                le = c[cont];
                if (char.IsLetter(le) || char.IsPunctuation(le))
                    return true;
            }
            return false;
        }
    }
}
