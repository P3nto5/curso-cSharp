using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOs.Entities
{
    class OrdemServico
    {
        public Servicos servicos { get; set; }

        public OrdemServico()
        {
        }

        public OrdemServico(Servicos servicos)
        {
            this.servicos = servicos;
        }

        public override string ToString()
        {
            return "Quantidade de serviçoes"
                + servicos.QuantService;
        }
    }
}
