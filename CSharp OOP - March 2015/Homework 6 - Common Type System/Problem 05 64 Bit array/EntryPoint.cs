namespace Problem_05_64_Bit_array
{
    using Problem_05_64_Bit_array.Classes;
    using System;
    /* Define a class BitArray64 to hold 64 bit values inside an ulong value.
     * Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=. */
    class EntryPoint
    {
        static void Main()
        {
            BitArray64 array = new BitArray64(0);

            // set
            array[2] = 1;
            Console.WriteLine(array[2]);

            // unset
            array[2] = 0;
            Console.WriteLine(array[2]);

            // second array for testing equality
            BitArray64 array2 = new BitArray64(1);

            //not equal
            Console.WriteLine("Not equal.(false)");
            Console.WriteLine(array == array2);

            // equal
            Console.WriteLine("Equal(true)");
            array[0] = 1;
            Console.WriteLine(array == array2);

            // fill with 1,0,1,0 ....
            for (int i = 0; i < 64; i = i + 2)
            {
                array[i] = 1;
            }

            // show
            int counter = 0;
            Console.WriteLine("Show filled array");
            foreach (var bit in array)
            {
                Console.Write("At index: {0} => ", counter++);
                Console.WriteLine(bit);
            }
        }
    }
}
