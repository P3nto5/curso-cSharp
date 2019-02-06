using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int s1 = Calculator.Sum(new int[] { 2, 7 });

            Console.WriteLine(s1);
            Console.ReadKey(true);
        }
    }
}
