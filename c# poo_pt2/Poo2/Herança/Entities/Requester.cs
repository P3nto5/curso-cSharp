using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOs.Entities
{
    class Requester
    {
        public string NameRequest { get; set; }
        public int CodeRequest { get; set; }

        public Requester()
        {
        }

        public Requester(string nameRequest, int codeRequest)
        {
            NameRequest = nameRequest;
            CodeRequest = codeRequest;
        }
        public override string ToString()
        {
            return "Nome do requisitante: \n"
                + NameRequest
                + " - Code do requisitante: \n"
                + CodeRequest;
        }
    }


}
