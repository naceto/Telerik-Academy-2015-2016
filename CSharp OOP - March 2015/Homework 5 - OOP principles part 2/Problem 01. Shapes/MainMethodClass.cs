namespace Problem_01.Shapes
{
    using System;
    using Problem_01.Shapes.Classes;

    class MainMethodClass
    {
        static void Main()
        {
            Shape[] array = 
            {
                new Rectangle (4, 5),
                new Square (5, 5),
                new Triangle (10, 6)
            };

            foreach (var shape in array)
            {
                Console.WriteLine("{0}: {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}
