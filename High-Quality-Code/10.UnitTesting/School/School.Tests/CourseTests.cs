namespace School.Tests
{
    using System;
    using System.Reflection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        private const int validStudentIdMin = 10000;
        private const int validStudentIdMax = 99999;
        private const string validStudentName = "Pesho";

        [TestMethod]
        public void Join30DiffernetStudentsInACourse()
        {

            var course = new Course();
            for (int i = 0; i < 30; i++)
            {
                var student = new Student(validStudentName, validStudentIdMin + i);
                course.Join(student);
            }
        }

        [TestMethod]
        public void SignedStudentTryToLeaveTheCourse()
        {
            var course = new Course();
            var student1 = new Student(validStudentName, validStudentIdMin);
            course.Join(student1);
            course.Leave(student1);
        }


        [ExpectedException(typeof(ApplicationException))]
        [TestMethod]
        public void StudentsInACourseShouldBeLessThan30()
        {

            var course = new Course();
            for (int i = 0; i < 31; i++)
            {
                var student = new Student(validStudentName, validStudentIdMin + i);
                course.Join(student);
            }
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void SameStudentTringToJoinTwoTimesInTheSameCourse()
        {
            var course = new Course();
            var student = new Student(validStudentName, validStudentIdMin);
            course.Join(student);
            course.Join(student);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void NotSignedStudentTryToLeaveTheCourse()
        {
            var course = new Course();
            var student1 = new Student(validStudentName, validStudentIdMin);
            var student2 = new Student(validStudentName, validStudentIdMin+1);
            course.Join(student1);
            course.Leave(student2);
        }
    }
}
