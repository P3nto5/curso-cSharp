using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vt = new string[] { "Maria", "joana", "noel" };
            foreach (var obj in vt)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey(true);
        }
    }
}
