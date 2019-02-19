using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadaOs.Entities
{
    class Service
    {
        public string nameService { get; set; }
        public string Code { get; set; }
        public DateTime HourExit { get; set; }
        public DateTime HourEntry { get; set; }
        

        public Service()
        {

        }

        public Service(string name, string code, DateTime hourExit, DateTime hourEntry)
        {
            this.nameService = name;
            Code = code;
            HourExit = hourExit;
            HourEntry = hourEntry;
        }
        public override string ToString()
        {
            return "Name"
                + nameService
                + "Code"
                + Code
                + "Hour Exit"
                + HourExit.ToString("HH:mm:ss")
                + "Hour Return"
                + HourEntry.ToString("HH:mm:ss");
        }
    }
}
