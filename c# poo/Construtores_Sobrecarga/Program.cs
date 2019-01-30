using System;
using System.Globalization;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: \n");
            var Nome = Console.ReadLine();
            Console.Write("Preço: \n");
            var Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: \n");
            var Quantidade = int.Parse(Console.ReadLine());

            Global G = new Global(Nome,Preco,Quantidade);
           // Global G_1 = new Global(Nome, Preco, Quantidade);

          //  Global G_3 = new Global
           // {
           //     Nome = "Tv",
           //     Preco = 500.00,
          //      Quantidade = 2
          //  };

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adcionado  ");
            int Adcionar = int.Parse(Console.ReadLine());
            G.AdcionaProduto(Adcionar);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser excluidos ");
            int Excluir = int.Parse(Console.ReadLine());
            G.ExcluirProduto(Excluir);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + G);

            Console.ReadKey(true);


        }
    }
}
