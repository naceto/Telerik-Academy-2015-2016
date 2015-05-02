using System;
using System.Text;

namespace Substring
{
    /* Implement an extension method Substring(int index, int length) for the 
     * class StringBuilder that returns new StringBuilder and has the same functionality 
     * as Substring in the class String. 
     */

    class MainClass
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("HELOOOOOOOOO");
            string str = sb.Substring(3, 5);
            Console.WriteLine(str);

            int[] coll = new int[] { 1, 2, 3, 4, 5, 6, 7};
            int result = coll.MyMax();
            result = coll.MyProduct();
            Console.WriteLine(coll.MyAverage());
        }
    }
}
