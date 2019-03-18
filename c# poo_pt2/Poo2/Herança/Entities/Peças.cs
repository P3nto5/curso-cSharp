using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOs.Entities
{
    class Peças
    {
        public string NameComponent { get; set; }
        public int CodeComponent { get; set; }
        public int QuantComponent { get; set; }

        public Peças()
        {
        }

        public Peças(string nameComponent, int codeComponent, int quantComponent)
        {
            NameComponent = nameComponent;
            CodeComponent = codeComponent;
            QuantComponent = quantComponent;
        }
        public int ContPeças()
        {
            return QuantComponent;
        }
        public override string ToString()
        {
            return "Nome da peça: \n"
                + NameComponent
                + " - Codigo do componente: \n"
                + CodeComponent
                + "  - Quantida de componentes: \n"
                + QuantComponent;
        }
    }
}
