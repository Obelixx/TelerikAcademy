namespace _3.Animal_hierarchy.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Animal_hierarchy.Interfaces;

    enum Sex
    {
        Female,
        Male
    }

    abstract class Animal : ISound
    {
        //age, name and sex
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Sex sex;
        internal Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Animal(int age,string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Animal!");
        }
    }
}
