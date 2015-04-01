namespace _3.Animal_hierarchy.Models
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name)
            : base(age, name,Sex.Male)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
