using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composi;
using Composi.Entities;
using Composi.Entities.Enums;

namespace Composi.Entities
{
    class Departament
    {
        public string Name { get; set; }

        public Departament()
        {
        }

        public Departament(string name)
        {
            this.Name = name;
        }
    }
}
