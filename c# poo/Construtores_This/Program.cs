using System;
using System.Globalization;

namespace Loja
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Global G = new Global();

            //Global G = new Global();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: \n");
            G.Nome = Console.ReadLine();
            Console.Write("Preço: \n");
            G.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: \n");
            G.Quantidade = int.Parse(Console.ReadLine());

            
            
            //Global G_2 = new Global(Nome, Preco);
               
             // Global G_3 = new Global
             // {
             //     Nome = "Tv",
             //     Preco = 500.00,
             //     Quantidade = 2
            //  };

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adcionado  ");
            var Adcionar = int.Parse(Console.ReadLine());
            G.AdcionaProduto(Adcionar);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser excluidos ");
            var Excluir = int.Parse(Console.ReadLine());
            G.ExcluirProduto(Excluir);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + G);

            Console.ReadKey(true);


        }
    }
}
