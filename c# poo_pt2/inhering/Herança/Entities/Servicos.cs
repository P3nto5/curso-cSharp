using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOs.Entities
{
    class Servicos
    {
        public string NameService { get; set; }
        public int CodeService { get; set; }
        public int QuantService { get; set; }

        public Servicos()
        {
        }

        public Servicos(string nameService, int codeService, int quantService)
        {
            NameService = nameService;
            CodeService = codeService;
            QuantService = quantService;
        }
        public int ContService()
        {
            return QuantService;
        }
        public override string ToString()
        {
            return "Nome do serviço: \n"
                + NameService
                + "Codigo do serviço"
                + CodeService;
               

        }

    }
}
