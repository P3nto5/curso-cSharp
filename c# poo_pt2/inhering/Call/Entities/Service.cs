using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Call.Entities;
using Call.Entities.Enums;

namespace Call.Entities
{
    class Service
    {
        public string NameService { get; set; }
        public string CodeService { get; set; }
        public int QuantService { get; set; }

        public Service()
        {
        }

        public Service(string nameService, string codeService, int quantService)
        {
            this.NameService = nameService;
            this.CodeService = codeService;
            this.QuantService = quantService;
        }

        public int ContService()
        {
            return QuantService;
        }
        public override string ToString()
        {
            return "Name service: \n - "
                + NameService
                + " - Code service: \n"
                + CodeService
                + " - Quantity service: \n"
                + QuantService;
                
        }

    }
}
