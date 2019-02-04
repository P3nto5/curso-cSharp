using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_collector
{
    class Program
    {
        static void Main(string[] args)
        {
            Global g = new Global();
            Console.WriteLine(g);
        }
        void method()
        {
            Global g = method_2();
           

        }
        Global method_2()
        {
            Global prod = new Global("tv", 900.0, 1);
            return prod;
        }
    }
}
