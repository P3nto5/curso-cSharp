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
        public String GetNome()
        {
            return _Nome;

        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _Nome = nome;
            }

        }

        public Double GetPreco()
        {
            return _Preco;

        }
        public void SetPreco(Double preco)
        {
            if (preco != 0.0 )
            {
                _Preco = preco;
            }

        }


        public int GetQuantidade()
        {
            return _Quantidade;

        }
        public void SetQuantidade(int quantidade)
        {
            if (quantidade != 0 )
            {
                _Quantidade = quantidade;
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
