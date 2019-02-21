using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Call.Entities;
using Call.Entities.Enums;

namespace Call.Entities
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
            this.NameComponent = nameComponent;
            this.CodeComponent = codeComponent;
            this.QuantyComponent = quantyComponent;
        }
        public int TotalComponents()
        {
            return QuantyComponent;
        }
        public override string ToString()
        {
            return "Name component: \n - "
                + NameComponent
                + " - Code component"
                + CodeComponent
                + " - Quantity component - "
                + QuantyComponent;
                
        }



    }
}
