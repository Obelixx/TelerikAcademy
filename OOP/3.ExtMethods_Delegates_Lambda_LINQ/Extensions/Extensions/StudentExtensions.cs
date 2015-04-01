namespace Extensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Student_namespace;

    //Todo: Problem 3. First before last
    //Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
    //Use LINQ query operators.

    //Todo: Problem 4. Age range
    //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    //Todo: Problem 5. Order students
    //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
    //Rewrite the same with LINQ.

    public static class StudentExtensions
    {

        public static Student[] FirstBeforLast(this Student[] students)
        {
            return (
                students
                .ToList()
                .FindAll(st => st.FirstName.CompareTo(st.LastName) < 0)
                .ToArray()
                );
        }

        public static List<Student> Between18and24(this Student[] students)
        {
            return (
                students
                .ToList()
                .FindAll(st => st.Age >= 18 && st.Age <= 24)
                );
        }

        public static void OrderStudents(this Student[] students)
        {
            students
                .OrderBy(st => st.FirstName)
                .ThenBy(st => st.LastName);
        }


        // Todo: Problem 10. Student groups extensions
        //Implement the previous using the same query expressed with extension methods.

        public static List<Student> SelectFromGroup2(this List<Student> list)
        {
            return (list.FindAll(st => st.GroupNumber == 2));
        }
        public static void OrderByFirstName(this List<Student> list)
        {
            list =
                new List<Student>(
                    from st in list
                    orderby st.FirstName
                    select st);
        }

        // Todo: Problem 11. Extract students by email
        //Extract all students that have email in abv.bg.
        //Use string methods and LINQ.
        public static List<Student> SelectMaliAbv_String(this List<Student> list)
        {
            return (list.FindAll(st => st.Email.Substring(st.Email.Length - 7, 6).ToLower() == "abv.bg"));
        }

        public static List<Student> SelectMaliAbv_Linq(this List<Student> list)
        {
            return (new List<Student>(from st in list
                                      where st.Email.Substring(st.Email.Length - 6, 6).ToLower() == "abv.bg"
                                      select st)
            );
        }

        // Todo: Problem 12. Extract students by phone
        //Extract all students with phones in Sofia.
        //Use LINQ.
        public static List<Student> SelectSofiaPhone_Linq(this List<Student> list)
        {
            return (new List<Student>(from st in list
                                      where st.Tel.Trim(' ').Contains("3592")
                                      select st)
            );
        }

        //  Todo: Problem 13. Extract students by marks
        //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
        //Use LINQ.
        public static List<dynamic> SelectByMarks_Linq(this List<Student> list)
        {
            var selectedStudents = new List<Student>(from st in list
                                                     where st.Marks.Contains(6)
                                                     select st);
            var anon = new List<dynamic>();
            foreach (var student in selectedStudents)
            {
                anon.Add(new { student.FirstName, student.Marks });
            }
            return (anon);
        }

        // Todo: Problem 14. Extract students with two marks
        //Write down a similar program that extracts the students with exactly two marks "2".
        //Use extension methods.
        public static List<dynamic> SelectByMarks2and2(this List<Student> list)
        {
            var selectedStudents = new List<Student>(from st in list
                                                     where st.Marks.Count == 2 && st.Marks[0] == 2 && st.Marks[1] == 2
                                                     select st);
            var anon = new List<dynamic>();
            foreach (var student in selectedStudents)
            {
                anon.Add(new { student.FirstName, student.LastName });
            }
            return (anon);
        }

        // Todo: Problem 15. Extract marks
        //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
        public static List<sbyte> ExtractMarksByFn2006(this List<Student> list)
        {
            var selectedStudents = new List<Student>(from st in list
                                                     where st.FN.ToString().Length >= 8 && st.FN.ToString()[6] == '0' && st.FN.ToString()[7] == '6'
                                                     select st);
            var marks = new List<sbyte>();
            foreach (var student in selectedStudents)
            {
                foreach (var mark in student.Marks)
                {
                    marks.Add(mark);
                }
            }
            return (marks);
        }

        //Problem 18. Grouped by GroupNumber
        //   Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
        //    Use LINQ.

        // Todo: Problem 19. Grouped by GroupName extensions
        //    Rewrite the previous using extension methods.
        static void PrintGroupedByGroupNumber(this List<Student> list)
        {
            var grupedStudents = new List<Student>(from st in list
                                                   orderby st
                                                   select st);
            foreach (var student in grupedStudents)
            {
                Console.WriteLine(student);
            }
        }


    }
}
