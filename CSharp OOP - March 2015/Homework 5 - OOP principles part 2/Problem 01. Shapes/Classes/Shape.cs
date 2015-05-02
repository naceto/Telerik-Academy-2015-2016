namespace Problem_01.Shapes.Classes
{
    using System;
    // Define abstract class Shape with only one abstract method 
    // CalculateSurface() and fields width and height.
    public abstract class Shape
    {
        private int width;
        private int height;

        public Shape ()
        {
            this.width = 0;
            this.height = 0;
        }

        public Shape (int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        // abstract == vitrtual in this case
        public abstract int CalculateSurface();

        public int Width
        {
            get { return this.width; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("width cannot be negative.");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("heigth cannot be negative.");
                }
                this.height = value;
            }
        }
    }
}
