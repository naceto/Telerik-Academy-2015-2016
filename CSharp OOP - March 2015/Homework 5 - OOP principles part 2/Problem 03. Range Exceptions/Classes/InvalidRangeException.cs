namespace Problem_03.Range_Exceptions.Classes
{
    using System;

    // Define a class InvalidRangeException<T> that holds information about an error 
    // condition related to invalid range. It should hold error message and a range definition [start … end].
    public class InvalidRangeException<T> : Exception
    {
        public InvalidRangeException(string msg)
            : base(msg)
        { }

        public T rangeStart { get; set; }
        public T rangeEnd { get; set; }
    }
}
