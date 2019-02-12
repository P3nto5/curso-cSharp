using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Pensao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of studentes that will stay in hotel");
            int n = int.Parse(Console.ReadLine());

            List<Students> listStudents = new List<Students>();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter the "+i+"° of the room :");
                int numberRoom = int.Parse(Console.ReadLine());
                if (numberRoom>0 && numberRoom<10)
                {
                    Console.WriteLine("Free room");
                                                                         
                }
                else
                {
                    Console.WriteLine("unknow room");
                }
                listStudents.Add(new Students(numberRoom));
          
            }
            foreach (Students obj in listStudents)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey(true);
        }
    }
}
