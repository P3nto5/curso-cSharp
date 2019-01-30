using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Loja
{
    class Global
    {
        private string _Nome;
        private double _Preco;
        private int _Quantidade;

        public Global()
        {
        }

        public Global(string nome, double preco) : this()
        {
            _Nome = nome;
            _Preco = preco;

        }
        public Global(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _Nome = nome;
            _Preco = preco;
            _Quantidade = quantidade;

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
        
        public Double Preco
        {
            get { return _Preco; }
            set
            {
                if (value != 0.0)
                {
                    _Preco = value;
                }
            }

        }
       
        public int Quantidade
        {
            get { return _Quantidade; }
            set
            {
                if (value != 0)
                {
                    _Quantidade = value;
                }
            }

        }
      
        public Double ValorTotal()
        {
            return _Preco * _Quantidade;
        }
        public void AdcionaProduto(int quantidade)
        {
            _Quantidade += quantidade;
        }
        public void ExcluirProduto(int quantidade)
        {
            _Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _Nome
                + ", $ "
                + _Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _Quantidade
                + " Unidades, total: $ "
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
