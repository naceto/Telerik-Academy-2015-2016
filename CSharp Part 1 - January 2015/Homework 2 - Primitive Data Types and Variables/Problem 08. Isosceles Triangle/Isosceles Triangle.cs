using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8; 
        string triangle = @"   ©

  © ©

 ©   ©

© © © ©";
        Console.WriteLine(triangle);
    }
}
