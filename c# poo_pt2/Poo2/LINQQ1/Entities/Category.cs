using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQQ1.Entities
{
    class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public int tier { get; set; }

        public Category()
        {
        }

        public Category(int id, string name, int tier)
        {
            this.id = id;
            this.name = name;
            this.tier = tier;
        }
    }
}
