using System;
using System.Globalization;

namespace Loja
{
    class Program
    {
        static public int Adcionar;
        static public int Excluir;


        static void Main(string[] args)
        {

             Console.WriteLine("Entre com os dados do produto");
             Console.Write("Nome: \n");
             var Nome = Console.ReadLine();
             Console.Write("Preço: \n");
             var Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             Console.Write("Quantidade: \n");           
             var Quantidade = int.Parse(Console.ReadLine());

            
            Global G = new Global(Nome, Preco, Quantidade);
            

            Console.WriteLine();
            Console.WriteLine("Dados do produto "+G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adcionado  ");
            Adcionar = int.Parse(Console.ReadLine());
            G.AdcionaProduto(Adcionar);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados "+ G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser excluidos ");
            Excluir = int.Parse(Console.ReadLine());

            G.ExcluirProduto(Excluir);            
            Console.WriteLine();          
            Console.WriteLine("Dados Atualizados " + G);

           Console.ReadKey(true);


        }
    }
}
