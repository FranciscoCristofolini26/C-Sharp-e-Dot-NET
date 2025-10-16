namespace Course
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double AreaT()
        {
            double p = (A + B + C) / 2.0;
            double areaX = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }


}



