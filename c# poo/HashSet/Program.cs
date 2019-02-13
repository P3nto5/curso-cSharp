using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(4);
            A.Add(5);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            Console.WriteLine("-------------conjunto a");
            foreach (var x in A)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------conjunto b");
            foreach (var x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Enter a intenger number: ");
            int n = int.Parse(Console.ReadLine());

            if (B.Contains(n))
            {
                Console.WriteLine(n + " percente ao conjunto B");
            }
            else
            {
                Console.WriteLine(n + " nao pertence ao conjunto b");
            }

            B.Remove(n);
            Console.WriteLine("--------------removido o n");
            foreach (var x in B)
            {
                Console.WriteLine(x);
            }

            A.ExceptWith(B);
            Console.WriteLine("--------------diferentes entre a e b");
            foreach (var x in A)
            {
                Console.WriteLine(x);
            }

            A.UnionWith(B);
            Console.WriteLine("-------------uniao a em b");
            foreach (var x in A)
            {
                Console.WriteLine(x);
            }

            Console.ReadKey(true);
        }
    }
}
