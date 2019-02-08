using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number;
            Console.WriteLine("Digite um numero : ");
            number = int.Parse(Console.ReadLine());
            Global.triplo(ref number);
            Console.WriteLine("Ref and triplo"+number);
            int quadruplo;
            Global.quadruplo(number,out quadruplo);
            Console.WriteLine("out and quadruplo"+quadruplo);

            Console.ReadKey(true);
        }
    }
}
