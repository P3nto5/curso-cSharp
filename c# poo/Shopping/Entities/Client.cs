using System;

namespace Shopping.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return Name
                + ", ("
                + birthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
