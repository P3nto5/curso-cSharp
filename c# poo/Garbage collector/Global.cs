using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_collector
{
    class Global
    {
        private string name;
        public double preco { get;  set; }
        public int quantidade { get;  set; }

        public Global()
        {
        }

        public Global(string name, double preco)
        {
            this.name = name;
            this.preco = preco;
        }

        public Global(string name, double preco, int quantidade) : this(name, preco)
        {
            this.quantidade = quantidade;
        }

        public override string ToString()
        {
            return "Nome: " + name +
                "Preço: " + preco +
                "Quantidade" + quantidade;
                
        }

    }
}
