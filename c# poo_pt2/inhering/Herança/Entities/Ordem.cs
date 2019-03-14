using CallOs.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOs.Entities
{
    class Ordem
    {
        public DateTime DateTime { get; set; }
        public EnumServico Status { get; set; }
        public Trainee Trainee { get; set; }
        public Requester Requester { get; set; }
        public OrdemServico OrdemServicos { get; set; } 
        public List<Servicos> Servicos { get; set; }
        public List<Peças> Peças { get; set; } = new List<Peças>();

        public Ordem()
        {
        }

        public Ordem(DateTime dateTime, EnumServico status, Trainee trainee, Requester requester)
        {
            DateTime = dateTime;
            Status = status;
            Trainee = trainee;
            Requester = requester;
        }

        public void AddService(Servicos servico)
        {
            Servicos.Add(servico);
        }
        public void RemoveService(Servicos servicos)
        {
            Servicos.Remove(servicos);
        }

        public void AddPecas(Peças peças)
        {
            Peças.Add(peças);
        }
        public void RemovePecas(Peças peças)
        {
            Peças.Remove(peças);
        }

        public int TotalService()
        {
            int sum = 0;
            foreach (Servicos serv in Servicos)
            {
                sum += serv.ContService();
            }
            return sum;
        }
        public int TotalPeca()
        {
            int sum = 0;
            foreach (Peças pec in Peças)
            {
                sum += pec.ContPeças();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine("Order moment: \n" + DateTime.ToString("dd/MM/yyyy"));
            stb.AppendLine("Status: \n" + Status);
            stb.AppendLine("Dados estagiarios" + Trainee);
            stb.AppendLine("Dados requisitante" + Requester);

            foreach  (Servicos serv in Servicos)
            {
                stb.AppendLine(serv.ToString());
            }
            stb.AppendLine("Total serviços" + TotalService());
            foreach (Peças pec in Peças)
            {
                stb.AppendLine(pec.ToString());
            }
            stb.AppendLine("Total de peças" + TotalPeca());
            return stb.ToString();
        }


    }
}
