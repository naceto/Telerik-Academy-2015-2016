namespace Problem_04_Person_class.Classes
{
    using System;

    /* Create a class Person with two fields – name and age. 
     * Age can be left unspecified (may contain null value.
     */
    public class Person
    {
        private string name;

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.name = value;
            }

        }

        public int? Age { get; set; }

        // Override ToString() to display the information of a person and if age is not specified – to say so.
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? "<Uspecified>" : this.Age.ToString());
        }
    }
}
