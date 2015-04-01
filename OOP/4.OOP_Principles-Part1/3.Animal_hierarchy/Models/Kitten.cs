namespace _3.Animal_hierarchy.Models
{
    class Kitten:Cat
    {
        public Kitten(int age, string name)
            : base(age, name,Sex.Female)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
