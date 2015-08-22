namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private ICollection<Course> courses = new List<Course>();

        private ICollection<Student> students = new List<Student>();

        public int SignStudent(string name)
        {
            var st = new Student(name, this.students.Count + 10000);
            students.Add(st);
            return st.Id;
        }
    }
}
