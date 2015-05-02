namespace Problem_01.Shapes.Classes
{
    using System;

    class Triangle : Shape
    {
        public Triangle (int width, int height)
            : base(width, height)
        {}

        public override int CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }
}
