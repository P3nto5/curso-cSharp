using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOs.Entities
{
    class Trainee
    {
        public string NameTrainee { get; set; }
        public string EmailTrainee { get; set; }
        public string NumberTrainee { get; set; }
        public int CodeTrainee { get; set; }
        public DateTime DataDeEntrada { get; set; }

        public Trainee()
        {
        }

        public Trainee(string nameTrainee, string emailTrainee, string numberTrainee, int codeTrainee, DateTime dataDeEntrada)
        {
            NameTrainee = nameTrainee;
            EmailTrainee = emailTrainee;
            NumberTrainee = numberTrainee;
            CodeTrainee = codeTrainee;
            DataDeEntrada = dataDeEntrada;
        }

        public override string ToString()
        {
            return "Nome do estagiario: - \n"
                + NameTrainee
                + " - Email \n"
                + EmailTrainee
                + " - Numero do estagiagio: \n"
                + NumberTrainee
                + " - Code do estagiario: \n"
                + CodeTrainee
                + " - Ano de entrada: \n"
                + DataDeEntrada.ToString("dd/MM/yyy");
            
        }
    }
}
