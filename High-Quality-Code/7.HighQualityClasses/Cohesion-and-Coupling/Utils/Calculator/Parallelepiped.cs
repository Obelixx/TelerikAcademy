namespace CohesionAndCoupling.Utils.Calculator
{
    using System;
    using CohesionAndCoupling.Utils.Calculator;

    public class Parallelepiped
    {
        public Parallelepiped(double width, double height, double depth)
        {
            if (width == 0 || height == 0 || depth == 0)
            {
                throw new ArgumentException("Width, height and depth can not be zero.");
            }

            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width { get; private set; }

        public double Height { get; private set; }

        public double Depth { get; private set; }

        public double Volume
        {
            get
            {
                return this.Width * this.Height * this.Depth;
            }
        }

        public double DiagonalXYZ
        {
            get
            {
                return Distance.CalculateIn3D(0, 0, 0, this.Width, this.Height, this.Depth);
            }
        }

        public double DiagonalXY
        {
            get
            {
                return Distance.CalculateIn2D(0, 0, this.Width, this.Height);
            }
        }

        public double DiagonalXZ
        {
            get
            {
                return Distance.CalculateIn2D(0, 0, this.Width, this.Depth);
            }
        }

        public double DiagonalYZ
        {
            get
            {
                return Distance.CalculateIn2D(0, 0, this.Height, this.Depth);
            }
        }
    }
}