using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account.Entiities.Exception
{
    class DomainExceptino : ApplicationException
    {
        public DomainExceptino(string message)
            :base(message)
        {

        }
    }
}
