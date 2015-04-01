namespace _3.Animal_hierarchy.Models
{
    class Cat : Animal
    {
        public Cat(int age, string name, Sex sex)
            : base(age, name, sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
    }
}
