namespace _3.Animal_hierarchy.Models
{
    class Dog : Animal
    {
        public Dog(int age, string name, Sex sex)
            : base(age, name, sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
    }
}
