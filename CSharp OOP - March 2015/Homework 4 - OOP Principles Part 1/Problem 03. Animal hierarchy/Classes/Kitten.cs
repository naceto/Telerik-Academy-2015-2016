namespace Problem_03.Animal_hierarchy.Classes
{
    using Problem_03.Animal_hierarchy.Enumerations;
    using System;
    //Kittens can be only female and tomcats can be only male.
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age)
        {
            base.Sex = Gender.Female;
        }

        public override string MakeSound()
        {
            return string.Format("Kitten: {0}", base.MakeSound());
        }
    }
}
