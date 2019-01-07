using System;
using System.Globalization;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto_1 = "Computador";
            string produto_2 = "Mesa de escritorio";

            byte idade = 24;
            int codigo = 5290;
            char genero = 'M';

            double preco_1 = 2100.0;
            double preco_2 = 650.0;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine(produto_1+", cujo preço é $"+preco_1);
            Console.WriteLine(produto_2+", cujo preço é $"+preco_2);

            Console.WriteLine("Registro: "+idade+" anos, codigo "+codigo+" e genero: "+genero);
            Console.WriteLine("Medida com oito casas decimais: "+medida.ToString("F8"));
            Console.WriteLine("Medida com 3 casas decimais: "+medida.ToString("F3"));
            Console.WriteLine("separador decimal invariante culture "+medida.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey(true);

        }
    }
}
