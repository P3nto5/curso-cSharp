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
                Console.WriteLine("Enter the "+i+"° of the room : \n");
                int numberRoom = int.Parse(Console.ReadLine());
                if (numberRoom>0 && numberRoom<10)
                {
                    Console.WriteLine("Ok room");
                    Students aux = listStudents.Find(x => x.Id == numberRoom);
                    if(aux != null)
                    {
                        Console.WriteLine("Occupied room enter outher room \n");
                        int numberFreeRoom = int.Parse(Console.ReadLine());
                        listStudents.Add(new Students(numberFreeRoom));

                    }
                    else
                    {
                        Console.WriteLine("Free room ");
                    }
                                                                         
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
