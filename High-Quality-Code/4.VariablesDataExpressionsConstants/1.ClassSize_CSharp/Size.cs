namespace SizeNamespace
{
    using System;

    /// <summary>
    /// Size class for refactoring homework - DONT USE IT!
    /// </summary>
    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get { return this.width; }
        }

        public double Height
        {
            get { return this.height; }
        }

        public static Size GetRotatedSize(Size size, double angle)
        {
            var newWidth = (Math.Abs(Math.Cos(angle)) * size.Width) + (Math.Abs(Math.Sin(angle)) * size.Height);
            var newHeight = (Math.Abs(Math.Sin(angle)) * size.Width) + (Math.Abs(Math.Cos(angle)) * size.Height);
            var newSize = new Size(newWidth, newHeight);
            return newSize;
        }
    }
}