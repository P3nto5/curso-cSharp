using ShapeArea.Entities.Enum;
using ShapeArea.Model.Entities;
using System;
namespace ShapeArea.Model.Entities
{
   abstract  class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
