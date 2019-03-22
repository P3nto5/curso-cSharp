using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dlegate.Service;

namespace Dlegate
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

           // BinaryNumericOperation op = new BinaryNumericOperation(CalcutationService.Max);
            BinaryNumericOperation op = CalcutationService.Max;
            op += CalcutationService.Sum;

           // double result = 
           //op.Invoke(a, b);
           op(a, b);
           // Console.WriteLine(result);
            Console.ReadKey(true);
        }
    }
}
