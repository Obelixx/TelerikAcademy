using System;
namespace Student_and_Person.Models
{
    class Person
    {
        //name and age
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else
                {
                    throw new ArgumentNullException("Name cant be null or empty!");
                }
            }
        }
        public int? Age { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            var result = "Pesrson: " + Name + Environment.NewLine +"Age: ";
            if(this.Age == null)
            {
                result += "[not specified]" + Environment.NewLine;
            }
            else
            {
                result += Age + Environment.NewLine;
            }
            return result; 
        }

    }
}
