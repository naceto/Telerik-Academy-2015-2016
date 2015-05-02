using System;
using System.Collections.Generic;
using System.Text;

namespace Substring
{
    public static class Extensions
    {
        /* Problem 1. StringBuilder.Substring
         * Implement an extension method Substring(int index, int length) for the 
         * class StringBuilder that returns new StringBuilder and has the same functionality 
         * as Substring in the class String. 
         */
        public static string Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder newsb = new StringBuilder();
            if (index > sb.Length || index + length > sb.Length)
            {
                throw new IndexOutOfRangeException("Index out of range.");
            }

            for (int i = 0; i < length; i++)
            {
                newsb.Append(sb[index + i]);
            }

            return newsb.ToString();
        }

        /*
         * Problem 2. IEnumerable extensions
         * Implement a set of extension methods for IEnumerable<T> that implement the 
         * following group functions: sum, product, min, max, average.
         */

        public static T MySum<T> (this IEnumerable<T> collection) where T : struct
        {
            T sum = (dynamic)0;
            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T MyProduct<T> (this IEnumerable<T> collection) where T : struct
        {
            T product = (dynamic)1;

            foreach (var item in collection)
            {
                product += (dynamic)item;
            }

            return product;
        }

        public static T MyMax<T> (this IEnumerable<T> collection) where T : struct
        {
            T? max = null;

            foreach (var item in collection)
            {
                if (max == null)
                {
                    max = item;
                    continue;
                }

                if ((dynamic)max < item)
                {
                    max = item;
                }
            }
            return max.GetValueOrDefault();
        }

        public static T MyMin<T> (this IEnumerable<T> collection) where T : struct
        {
            T? min = null;

            foreach (var item in collection)
            {
                if (min == null)
                {
                    min = item;
                    continue;
                }

                if ((dynamic)min > item)
                {
                    min = item;
                }
            }

            return min.GetValueOrDefault();
        }

        public static T MyAverage<T> (this IEnumerable<T> collection) where T : struct
        {
            T sum = (dynamic)0;
            int counter = 0;

            foreach (var item in collection)
            {
                sum += (dynamic)item;
                ++counter;
            }
            if (counter > 0)
            {
                return (dynamic)sum / counter;
            }
            else
            {
                return sum;
            }
        }
    }
}
