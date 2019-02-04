using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Arrays_Listas_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponteiro p;
            Console.WriteLine("Digite o valor de x");
            p.x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor de y");
            p.y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(p);

            Console.ReadKey(true);
        }
    }
}
