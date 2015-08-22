namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private ICollection<Student> students = new List<Student>();

        public void Join(Student student)
        {
            if (this.students.Count >= 30)
            {
                throw new ApplicationException("Course can't take more then 30 students.");
            }

            if (this.students.Contains(student))
            {
                throw new ArgumentException("This student is already signed for that course.");
            }

            this.students.Add(student);
        }

        public void Leave(Student student)
        {
            if (!this.students.Contains(student))
            {
                throw new ArgumentException("This student is not signed for that course.");
            }

            this.students.Remove(student);
        }
    }
}
