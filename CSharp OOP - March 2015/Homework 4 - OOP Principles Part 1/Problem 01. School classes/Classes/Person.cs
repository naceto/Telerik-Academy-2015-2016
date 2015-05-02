namespace Problem_01.School_classes.Classes
{
    using System;

    public abstract class Person
    {
        private string name;

        public Person (string name)
        {
            this.Name = name;
        }

        protected string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name cannot be null.");
                }
            }
        }
    }
}
