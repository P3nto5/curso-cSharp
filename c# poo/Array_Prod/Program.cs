using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Array_Prod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite a quantidade de produtos que voce deseja");
            n = int.Parse(Console.ReadLine());

            Global[] vect = new Global[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o "+(i+1)+" Nome: ");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o " + (i+1) + " Preço: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Global { Name = name, Price = price };
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVAREGE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey(true);
        }   
    }
}
