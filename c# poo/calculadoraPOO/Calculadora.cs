using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace calculadoraPOO
{
    class Calculadora
    {
       public Double numero_1 ;
       public Double numero_2 ;
       public string opcao;
       public string verifica;
       public  bool opcao_veri;
       public  bool vell;

        public double soma(double n1, double n2)
            {
                double resultado;
                resultado = n1 + n2;
                return resultado;
            }
        
       
            public double subtraçao(double n1, double n2)
            {
                double resultado;
                resultado = n1 - n2;
                return resultado;
            }
        
        
            public double multiplicaçao(double n1, double n2)
            {
                double resultado;
                resultado = n1 * n2;
                return resultado;
            }
        
     
            public double divisao(double n1, double n2)
            {
                double resultado;
                resultado = n1 / n2;
                return resultado;
            }
        
    }
}
