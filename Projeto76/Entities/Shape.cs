using Course.Entities.Enums;


namespace Course.Entities
{
    abstract class Shape
    {
        public Cor Cor { get; set; }

        public Shape(Cor color)
        {
            Cor = color;
        }
        public abstract double Area();

    }
}