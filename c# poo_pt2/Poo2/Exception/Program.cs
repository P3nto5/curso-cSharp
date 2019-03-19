using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                int n1 = int.Parse(Console.ReadLine());
                int result = (n / n1);
                Console.WriteLine(result);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Format error!" + f.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error !"+ e.Message);
            }
           

            Console.ReadKey(true);
        }
    }
}
