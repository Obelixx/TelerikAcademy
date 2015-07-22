namespace Abstraction
{
    using System;

    public class Circle : Figure, IFigure
    {
        private double radius;

        public Circle(double radius)
            : base()
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                Figure.CheckForPositiveNumber(value, "Radius");
                this.radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return this.Radius * 2;
            }

            private set
            {
                this.Radius = value / 2;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = Math.PI * this.Diameter;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
