using ShapeArea.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape()
        {
        }

        public Shape(Color color)
        {
            this.color = color;
        }
        public abstract double Area();
        
    }
}
