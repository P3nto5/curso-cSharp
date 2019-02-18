using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadaOs.Entities
{
    class Components
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Components()
        {
        }

        public Components(string name, int code)
        {
            Name = name;
            Code = code;
        }
    }
}
