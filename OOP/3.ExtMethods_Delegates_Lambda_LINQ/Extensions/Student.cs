namespace Student_namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    //created for problem 3,4 and 5;

    // Todo: Problem 9. Student groups
    //Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    //Create a List<Student> with sample students. Select only the students that are from group number 2.
    //Use LINQ query. Order the students by FirstName.

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ulong FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<sbyte> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string FirstName, string LastName, int Age, ulong FN, string Tel, string Email, List<sbyte> Marks, int GroupNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.FN = FN;
            this.Tel = Tel;
            this.Email = Email;
            this.Marks = Marks;
            this.GroupNumber = GroupNumber;
        }


        public static List<Student> StudentsSample()
        {
            var students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 17, 1, "+123123", "ivan@ivanov.com", new List<sbyte>() { 2, 2, 3, 4, 2 }, 1));
            students.Add(new Student("Ivan8", "Ivanov1", 18, 2, "+123123", "ivan@ivanov.com", new List<sbyte>() { 6, 2, 3, 4, 2 }, 2));
            students.Add(new Student("Ivan2", "Ivan1", 17, 3, "+3952123", "ivan1@abv.bg", new List<sbyte>() { 2, 2, 3, 4, 2 }, 1));
            students.Add(new Student("Ivan3", "Ivan2", 17, 4, "+395223", "ivan@ivanov.com", new List<sbyte>() { 2, 2 }, 5));
            students.Add(new Student("Ivan4", "Ivan3", 21, 5, "+123123", "ivan@abv.bg", new List<sbyte>() { 6, 2, 3, 4, 2 }, 5));
            students.Add(new Student("Ivan5", "Ivan4", 18, 060606, "+123123", "ivan2@abv.bg", new List<sbyte>() { 2, 2 }, 2));
            students.Add(new Student("Ivan6", "Ivan8", 17, 606060, "+3952223", "ivan@ivanov.com", new List<sbyte>() { 2, 6, 3, 4, 2 }, 1));
            return (students);
        }
        public static List<Student> SelectFromGroup2(List<Student> list)
        {
            return (list.FindAll(st => st.GroupNumber == 2));
        }
        public static List<Student> OrderByFirstName(List<Student> list)
        {
            return (
                new List<Student>(from st in list
                                  orderby st.FirstName
                                  select st)
            );
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("Name: " + FirstName + " " + LastName);
            sb.AppendLine("FN: " + FN);
            sb.AppendLine("Tel: " + Tel);
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Marks: ");
            foreach (var mark in Marks)
            {
                sb.Append("[");
                sb.Append(mark);
                sb.Append("]");

            }
            sb.AppendLine("GroupNumber: " + GroupNumber);
            //   FirstName = "Ivan", LastName = "Ivanov", FN = 1, Tel = "+123123", Email = "ivan@ivanov.com", Marks = { 2, 2, 3, 4, 2 }, GroupNumber = 1
            sb.AppendLine();
            return sb.ToString();
        }

    }
}
