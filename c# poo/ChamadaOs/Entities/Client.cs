using System;


namespace ChamadaOs.Entities
{
    class Client
    {
        public string NameEmploeed  { get; set; }
        public string EmailEmployeed { get; set; }
        public string CpfEmployeed { get; set; }
        public DateTime AnoEntradaEmplyeed { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, string cpf, DateTime anoEntrada)
        {
            NameEmploeed = name;
            EmailEmployeed = email;
            CpfEmployeed = cpf;
            AnoEntradaEmplyeed = anoEntrada;
        }

        public override string ToString()
        {
            return "Name Employeed: " 
                +NameEmploeed
                + " cpf("
                + CpfEmployeed.ToString()
                + ") - "
                + "Hour of received ("
                +AnoEntradaEmplyeed.ToString("dd/MM/yyyy")
                +") - email:"
                + EmailEmployeed;
        }
    }
}
