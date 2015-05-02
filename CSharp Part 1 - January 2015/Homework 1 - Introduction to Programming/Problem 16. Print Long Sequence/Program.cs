using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Print_Long_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                int num = i;
                if (num % 2 != 0)
                {
                    num *= -1;
                }
                Console.Write(num + ((i < 1001) ? ", " : "."));
            }
            Console.WriteLine();
        }
    }
}
