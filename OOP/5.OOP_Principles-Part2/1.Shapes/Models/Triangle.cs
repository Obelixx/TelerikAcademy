namespace _1.Shapes.Models
{
    using System;

    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height) { }

        public override double CalculateSurface()
        {
            return (base.CalculateSurface() / 2);
        }

        public override string ToString()
        {
            return ("Triangle size: [" + Width.ToString() + ":" + Height.ToString() + "]");
        }
    }
}
