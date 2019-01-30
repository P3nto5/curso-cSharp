using System;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opcao;
            int Quantidade;
            double total=0;
            Console.WriteLine("Digite o codigo para o que precida pedir");
            Console.WriteLine("1--- cachorro quente: preco R$ 4,00 ");
            Console.WriteLine("2--- x salada: preco R$ 4,50 ");
            Console.WriteLine("3--- x bacon: preco R$ 5,00 ");
            Console.WriteLine("4--- torrada simples: preco R$ 2,00 ");
            Console.WriteLine("5--- refrigerante: preco R$ 1,50 ");
            Opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade");
            Quantidade = int.Parse(Console.ReadLine());
            if(Opcao==1)
            {
                total = Quantidade * 4.00;
            }
            if (Opcao == 2)
            {
                total = Quantidade * 4.50 ;
            }
            if (Opcao == 3)
            {
                total = Quantidade * 5.00 ;
            }
            if (Opcao == 4)
            {
                total = Quantidade * 2.00 ;
            }
            if (Opcao == 5)
            {
                total = Quantidade * 1.50 ;
            }
            else
            {
                Console.WriteLine("codigo invalido");
            }
            


            Console.WriteLine("Total: R$ "+total);
            Console.ReadKey(true);

        }
    }
}
