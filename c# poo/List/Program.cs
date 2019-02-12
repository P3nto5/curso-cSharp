using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Alex");
            list.Add("Maria");
            list.Add("Alex");
            list.Add("bob");
            list.Add("ana");
            list.Insert(2, "Marco");
            

            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Numero de menbros"+list.Count);

            string s = list.Find(test);
            Console.WriteLine("First 'A'"+s);
            Console.ReadKey(true);
        }
        static bool test(string s)
        {
            return s[0] == 'A';
        }
    }
}
