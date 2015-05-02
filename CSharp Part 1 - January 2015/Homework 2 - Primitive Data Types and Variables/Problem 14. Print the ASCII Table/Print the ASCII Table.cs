using System;

class Program
{
    static void Main()
    {
        for (char i = (char)0; i <= 255; i++)
        {
            Console.Write(i + " ");
            if (i % 30 == 0)
            {
                Console.Write("\n");
            }
        }

    }
}
