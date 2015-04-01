namespace School_classess
{
    using System;
    using School_classess.Models;

    class TestProgram
    {
        static void Main()
        {

            var telerik = new School();
            Console.WriteLine(telerik);

            Console.WriteLine(telerik.Classes.Count);
            telerik.Classes.Add(new Class("10b"));
            Console.WriteLine(telerik.Classes.Count);
            telerik.Classes[0].Comment = "10b comment";
            telerik.Classes[0].Students.Add(new Student("Ivan"));
            telerik.Classes[0].Students.Add(new Student("Petyr"));
            telerik.Classes[0].Teachers.Add(new Teacher());

            foreach (var clas in telerik.Classes)
            {
                foreach (var student in clas.Students)
                {
                    Console.WriteLine(student.ClassNumber);
                }
                Console.WriteLine(clas.Comment);
                Console.WriteLine(clas.TextIdentifier);

            }

        }
    }
}
