using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Print_a_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 11; i++)
            {
                int num = i;
                if (num % 2 != 0)
                {
                    num *= -1;
                }
                Console.WriteLine(num);
            }
        }
    }
}
