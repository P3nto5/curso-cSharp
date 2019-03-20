using ShapeArea.Entities.Enum;
using ShapeArea.Model.Entities;
using System;



namespace ShapeArea.Entities
{
    class Circle : AbstractShape
    {

        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Circle color"
                + Color
                + ", radius ="
                + Radius.ToString()
                + ", area"
                + Area().ToString();
        }
    }
}
