using System;
using ShapeArea.Entities.Enum;
using ShapeArea.Model.Entities;

namespace ShapeArea.Entities
{
    class Rectangle : AbstractShape 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "Rectamgle color: "
                + Color
                + ", Width: "
                + Width
                + ",Height: "
                + Height
                + "Area: "
                + Area().ToString();
        }
    }
}
