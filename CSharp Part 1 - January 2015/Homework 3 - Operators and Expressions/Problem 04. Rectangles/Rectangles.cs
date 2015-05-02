using System;

class Rectangles
{
    /* Write an expression that calculates rectangle’s 
    * perimeter and area by given width and height. */
    static void Main()
    {
        Console.Write("Enter a rectagles width: ");
        double rectWidth = double.Parse(Console.ReadLine());
        Console.Write("Enter a rectagles height: ");
        double rectHeight = double.Parse(Console.ReadLine());
        double rectPerimeter = (2 * rectHeight) + (2 * rectWidth);
        double rectArea = rectWidth * rectHeight;
        Console.WriteLine("Rectangle's area is: {0} and rectangle's perimeter is: {1}.", rectArea, rectPerimeter);
    }
}
