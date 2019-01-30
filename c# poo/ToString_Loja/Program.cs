using System;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            Global G = new Global();


            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: \n");
            G.Nome = Console.ReadLine();
            Console.Write("Preço: \n");
            G.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: \n");
            G.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto " + G);


            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser adcionado  ");
            G.Adcionar = int.Parse(Console.ReadLine());
            G.AdcionaProduto(G.Adcionar);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + G);

            Console.WriteLine();
            Console.WriteLine("Digite o numero de produtos a ser excluidos ");
            G.Excluir = int.Parse(Console.ReadLine());
            G.ExcluirProduto(G.Excluir);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados " + G);







            Console.ReadKey(true);


        }
    }
}
