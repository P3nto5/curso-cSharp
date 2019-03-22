using System;
using System.Collections.Generic;
using Comparabe.Entities;
using System.IO;

namespace Comparabe
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Maria".CompareTo("Alex"));
           // Console.WriteLine("Alex".CompareTo("Maria"));
           // Console.WriteLine("Maria".CompareTo("Maria"));
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            
            Console.ReadKey(true);
            
        }
    }
}
