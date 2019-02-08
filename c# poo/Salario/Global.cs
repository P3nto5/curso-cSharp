using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Salario
{
    class Global
    {
        public string Nome;
        public Double SalarioBruto;
        public double Imposto;
        public Double Porcentagem;

        public double SalarioLiguido()
        {
            double result;
            result = SalarioBruto - Imposto;
            return result;
        }
        public void AumentarSalario(double porcent)
        {
            SalarioBruto = SalarioBruto+(SalarioBruto * (porcent/100));
            
        }
        public override string ToString()
        {
            return "Nome "+Nome
           + "\n Seu salario : "
           + SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)
           + "\n Imposto : "
           + Imposto.ToString("F2", CultureInfo.InvariantCulture)
           +"\n Seu salario liguido: "
           + SalarioLiguido().ToString("F2", CultureInfo.InvariantCulture);


        }

    }
}
