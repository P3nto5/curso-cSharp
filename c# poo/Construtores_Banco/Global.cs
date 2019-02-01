using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Construtores_Banco
{
    class Global
    {
        private int _Conta;
        public string _Titular { get; set; } 
        public Double Saldo { get; private set; }

        public Global()
        {
        }
        public Global(int Conta, string Titular)
        {
            _Conta = Conta;
            _Titular = Titular;           
        }
        public Global(int Conta, string Titular, double saldo) :this(Conta,Titular)
        {
            Saldo = saldo;
        }
        public void Deposito(Double quantia)
        {
            Saldo += quantia;
        }
        public bool VerificaSaldo(Double quantia)
        {
            if ( quantia<Saldo)
            {
                return true;
            }
            return false;

        }
        public void Saque(Double quantia)
        {
            Saldo -= quantia;
        }
        public override string ToString()
        {
           
            return "Conta: "
                + _Conta
                + ", Titular: "
                + _Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
