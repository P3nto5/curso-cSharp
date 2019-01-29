using System;
using System.Collections.Generic;
using System.Text;

namespace ConversaoMoeda
{
    class Global
    {
        public Double Quantidade;


        public double ValorPago(Double dol , Double quant)
        {
            return (dol+ (dol * 0.06)) * Quantidade ;
        }
    }
}
