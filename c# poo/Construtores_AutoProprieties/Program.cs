using System;
using System.Globalization;

namespace Loja
{
    class Program
    {



        static void Main(string[] args)
        {
            Global G = new Global();
            Console.WriteLine("Digite o nome do produto");
            var nome = Console.ReadLine();
            G.Nome = nome;
            //Console.WriteLine("Nome: "+G.GetNome());

            Console.WriteLine("Digite o preço do produto");
            var preco = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("Digite a quantidade de produtos");
            var quantidade = int.Parse(Console.ReadLine());

            Global g1 = new Global(G.Nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados: " + G);

            Console.WriteLine("digite a quantidade de produtos a adicionar");
            int adicona = int.Parse(Console.ReadLine());
            G.AdcionaProduto(adicona);

            Console.WriteLine("Produtos adcionados " + G);

            int excluir = int.Parse(Console.ReadLine());
            G.ExcluirProduto(excluir);

            Console.WriteLine("Produtos Excluidos " + G);



            Console.ReadKey(true);


        }
    }
}
