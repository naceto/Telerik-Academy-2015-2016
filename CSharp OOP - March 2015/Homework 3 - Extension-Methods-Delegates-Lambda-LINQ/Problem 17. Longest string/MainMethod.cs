namespace Problem_17.Longest_string
{
    using System;
    using System.Linq;
    /* 
     * Problem 17. Longest string
     * Write a program to return the string with maximum length from an array of strings.
     * Use LINQ. 
     */
    class MainMethod
    {
        private static Random rand;

        static MainMethod ()
        {
            rand = new Random();
        }

        static void Main()
        {
            string[] array = new string[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = new string((char)rand.Next(128), rand.Next(101));
            }

            // NOTE: the mothod will return different result every time due 
            // the method I use to create strings for the array, but it will aways return 
            // the longest string in the array
            Console.WriteLine(GetMaxLength(array));
        }

        static string GetMaxLength (string[] array)
        {
            var result = from s in array
                         orderby s.Length descending
                         select s;
            return result.First();
        }
    }
}
