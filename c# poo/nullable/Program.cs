using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? x_1 = null;
            double? y = 10;
          

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(x_1.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value);
            //Console.WriteLine(y.Value);

            if (x.HasValue)    {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X are null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y are null");
            }
            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey(true);


        }
    }
}
