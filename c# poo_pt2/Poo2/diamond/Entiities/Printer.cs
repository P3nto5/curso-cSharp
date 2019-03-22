using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diamond.Entiities
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Print: "+ document);
        }
        public void Print(string document)
        {
            Console.WriteLine("Print print" + document);
        }
    }
}
