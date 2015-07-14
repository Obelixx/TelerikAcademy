namespace _2.MakePersonInCSharp
{
    using System;

    // Schprehen sie Deutsch? (class Hauptklasse)
    public class MainClass
    {
        public enum Body
        {
            ultraPumpedBrother,
            hotChick
        }

        public static Person PersonMaker(int personAge)
        {
            Person newPerson = new Person();
            newPerson.Age = personAge;
            if (personAge % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.BodyType = Body.ultraPumpedBrother;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.BodyType = Body.hotChick;
            }

            return newPerson;
        }

        public static void Main()
        {
            Person person = PersonMaker(18);
            Console.WriteLine(person.Name + " is " + person.BodyType);
        }

        public class Person
        {
            public Body BodyType
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }
        }
    }
}
