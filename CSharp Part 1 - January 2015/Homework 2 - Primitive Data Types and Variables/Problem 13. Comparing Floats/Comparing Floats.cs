using System;

class Program
{
    static void Main()
    {
        double eps = 0.000001;
        double a = -0.0000007;
        double b = 0.00000007;
        bool? equal = null;

        if (Math.Abs (a - b) >= eps)
        {
            equal = false;
        }
        else
        {
            equal = true;
        }
        Console.WriteLine("Are numbers {0} and {1} equal?\nANS: {2}", a, b, equal);
    }
}

