namespace _3.Animal_hierarchy.Models
{
    class Frog : Animal
    {
        public Frog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
    }
}
