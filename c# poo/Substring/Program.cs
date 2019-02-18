using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Substring.Entities;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip! ");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2019 13:05:44 "),
                "Viajando para longe ",
                "Foda... o lugar e toperson ",
                12
                );
            
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
            Console.ReadKey(true);
        }
    }
}
