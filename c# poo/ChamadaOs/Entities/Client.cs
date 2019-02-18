using System;


namespace ChamadaOs.Entities
{
    class Client
    {
        public string Name  { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime AnoEntrada { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, string cpf, DateTime anoEntrada)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
            AnoEntrada = anoEntrada;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + Cpf.ToString()
                + ") -"
                + ", ("
                +AnoEntrada.ToString("dd/MM/yyyy")
                +"), -"
                + Email;
        }
    }
}
