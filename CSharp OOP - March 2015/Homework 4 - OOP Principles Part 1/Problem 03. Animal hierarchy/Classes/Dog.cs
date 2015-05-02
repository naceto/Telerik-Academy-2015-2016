namespace Problem_03.Animal_hierarchy.Classes
{
    using Problem_03.Animal_hierarchy.Enumerations;
    using System;

    class Dog : Animal
    {

        public Dog (string name, int age, Gender sex)
            : base (name, age)
        {
            this.Sex = sex;
        }

        public override Enumerations.Gender Sex { get; set; }

        public override string MakeSound()
        {
            return string.Format("Bark");
        }
    }
}
