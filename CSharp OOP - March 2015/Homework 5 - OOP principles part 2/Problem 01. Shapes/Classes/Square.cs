namespace Problem_01.Shapes.Classes
{
    using System;

    public class Square : Shape
    {
        public Square(int width, int height)
        {
            if (width != height)
            {
                throw new ArgumentException("width and height must be equal.");
            }
            this.Width = width;
            this.Height = height;
        }

        public override int CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
