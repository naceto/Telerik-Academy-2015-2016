namespace Problem_01.Shapes.Classes
{
    using System;

    public class Rectangle : Shape
    {

        public Rectangle(int width, int height)
            : base(width, height)
        {}

        public override int CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
