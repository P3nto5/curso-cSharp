using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlegate.Service
{
    class CalcutationService
    {
        public static void Max(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }
        public static void Sum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
       // public static double Square(double x, double y)
        //{
          //  return x * x;
        //}
    }
}
