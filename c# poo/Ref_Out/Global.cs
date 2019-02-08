using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Global
    {
        public static void triplo(ref int number)
        {
            number *= 3;
        }
        public static void quadruplo(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
