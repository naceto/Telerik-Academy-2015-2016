namespace Problem_03.Range_Exceptions
{
    using System;
    using Problem_03.Range_Exceptions.Classes;

    /* Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
     * by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013]. */
    class MainMethodClass
    {
        static void Main()
        {
            //int [1..100]
            try
            {
                ThrowIntExceptiong(150);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Exception cought: {0} [{1}, {2}]", ex.Message, ex.rangeStart, ex.rangeEnd);
            }

            // DateTime [1.1.1980 … 31.12.2013]
            try
            {
                ThrowDateException(new DateTime(2016, 7, 23));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Exception cought: {0} [{1}, {2}]", ex.Message, ex.rangeStart.ToShortDateString(), ex.rangeEnd.ToShortDateString());
            }
        }

        static void ThrowIntExceptiong(int index)
        {
            if (index < 0 || index > 100)
            {
                throw new InvalidRangeException<int>("Index must be between:") { rangeStart = 0, rangeEnd = 100 };
            }
        }

        static void ThrowDateException(DateTime date)
        {
            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);
            if (date > start || date < end)
            {
                throw new InvalidRangeException<DateTime>("Date must be between:") { rangeStart = start, rangeEnd = end };
            }
        }
    }
}
