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
            list.Add("Ana");
            list.Insert(2, "Marco");


            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Numero de menbros" + list.Count);

            string s = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A'"+s);

            string s_1 = list.FindLast(x => x[0] == 'A' );
            Console.WriteLine("Last 'A'" + s_1);

            int pos_1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos_1);

            int pos_2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos_2);

            List<string> list_2 = list.FindAll(a => a.Length == 5);
            Console.WriteLine("----------------- nova lista que so recebe nomes com 5 letras");
            foreach (var obj in list_2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("--------------remove o alex :( ");
            list.Remove("Alex");
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("----------------- remove por tamanho");
            list.RemoveRange(2, 2);
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey(true);
            Console.WriteLine("------------------- remove os nome com :(");
            list.RemoveAll(x => x[0] == 'M');
            foreach (var obj in list)
            {
                Console.WriteLine( obj);
            }
            Console.WriteLine("------------------- remove por posiçao");
            list.RemoveAt(2);
            foreach (var obj in list)
            {
                Console.WriteLine(obj);
            }
           
        }
        
    }
}
