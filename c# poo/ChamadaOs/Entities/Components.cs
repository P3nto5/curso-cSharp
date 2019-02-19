using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadaOs.Entities
{
    class Components
    {
        public string NameComponent { get; set; }
        public string CodeComponent { get; set; }
        public int QuantyComponent { get; set; }

        public Components()
        {
        }

        public Components(string nameComponent, string codeComponent, int quantyComponent)
        {
            NameComponent = nameComponent;
            CodeComponent = codeComponent;
            QuantyComponent = quantyComponent;
        }
        public int ContComp()
        {
            return QuantyComponent;
        }
        public override string ToString()
        {
            return "Quanty Component"               
                +ContComp().ToString();
        }

    }
}
