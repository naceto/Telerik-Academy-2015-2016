namespace Problem_03.Animal_hierarchy.Classes
{
    using Problem_03.Animal_hierarchy.Enumerations;
    using System;

    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {}

        public Cat(string name, int age, Gender sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        public override Gender Sex { get; set; }

        public override string MakeSound()
        {
            return string.Format("Miay");
        }
    }
}
