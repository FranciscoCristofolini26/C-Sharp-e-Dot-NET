using Course.Entities;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Cor color) : base(color)
        {
            Width = width;
            Height = height;
        }                
        public override double Area()
        {
            return Width * Height;
        }
    }
}