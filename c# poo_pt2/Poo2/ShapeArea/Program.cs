using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ShapeArea.Entities.Enum;
using ShapeArea.Entities;
using ShapeArea.Model.Entities;

namespace ShapeArea
{
    class Program
    {
        static void Main(string[] args)
        {

            IShape s1 = new Circle()
            {
                Radius = 2.0, Color = Color.Black
            };
            IShape s2 = new Rectangle()
            {
                Width = 3.5, Height = 4.2, Color = Color.White 
            };
            Console.WriteLine(s1);
            Console.WriteLine(s2);


           /* List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of shapes");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine($"Shape #{i} data");
                Console.WriteLine("Rectangle or cicle (r/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red)");
                Enum.TryParse(Console.ReadLine(), true, out Color color);
                if (ch == 'r')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS");
            foreach(Shape sh in list)
            {
                Console.WriteLine(sh.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            */
            Console.ReadKey(true);
        }
    }
}
