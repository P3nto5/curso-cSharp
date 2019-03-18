using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Call.Entities;
using Call.Entities.Enums;

namespace Call.Entities
{
    class Trainee
    {
        public string NameTrainee { get; set; }
        public string EmailTrainee { get; set; }
        public  DateTime EntryTrainee { get; set; }

        public Trainee()
        {
        }

        public Trainee(string nameTrainee, string emailTrainee, DateTime birthTrainee)
        {
            NameTrainee = nameTrainee;
            EmailTrainee = emailTrainee;
            this.EntryTrainee = birthTrainee;
        }
        public override string ToString()
        {
            return "Name of Trainee: \n - "
                + NameTrainee
                + " -  Email: \n"
                + EmailTrainee
                + " - Year of entry: \n - "
                + EntryTrainee.ToString("dd/MM/yyyy");
        }
    }
}
