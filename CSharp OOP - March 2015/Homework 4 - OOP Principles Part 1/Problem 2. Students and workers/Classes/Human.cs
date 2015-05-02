namespace Problem_2.Students_and_workers.Classes
{
    using System;

    // Define abstract class Human with a first name and a last name.
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human (string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }

            protected set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot be null.");
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }

            protected set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot be null");
                }
            }
        }
    }
}
