using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Loja
{
    class Global
    {
        private string _Nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Global()
        {
        }

        public Global(string nome, double preco) : this()
        {
            _Nome = nome;
            Preco = preco;

        }
        public Global(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
        public String Nome
        {
            get { return _Nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _Nome = value;
                }
            }

        }


        public Double ValorTotal()
        {
            return Preco * Quantidade;
        }
        public void AdcionaProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void ExcluirProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " Unidades, total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
