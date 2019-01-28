using System;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Global G = new Global();
            Console.WriteLine("Digite seu nome");
            G.Nome = Console.ReadLine();

            Console.WriteLine("Salario bruto");
            G.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto");
            G.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados: "+G);


            Console.WriteLine("digite a porcentagem para aumentar o salario");
            G.Porcentagem = double.Parse(Console.ReadLine());
            
            Console.WriteLine();
            G.AumentarSalario(G.Porcentagem);
            Console.WriteLine("Dados Atualizados"+G);


            Console.ReadKey(true);
        }
    }
}
