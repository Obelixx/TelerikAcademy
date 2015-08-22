using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class StudentTests
    {
        private const int validStudentIdMin = 10000;
        private const int validStudentIdMax = 99999;
        private const string ValidStudentName = "Pesho";

        [TestMethod]
        public void createValidStudentWithMinId()
        {
            Student st = new Student(ValidStudentName, validStudentIdMin);
            Assert.AreEqual(st.Name, ValidStudentName, "Provided valid name.");
            Assert.AreEqual(st.Id, validStudentIdMin, "Provided valid ID.");
        }

        [TestMethod]
        public void createValidStudentWithMaxId()
        {
            Student st = new Student(ValidStudentName, validStudentIdMax);
            Assert.AreEqual(st.Name, ValidStudentName, "Provided valid name.");
            Assert.AreEqual(st.Id, validStudentIdMax, "Provided valid ID.");
        }


        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void NameCanNotBeEmpty()
        {
            Student st = new Student(string.Empty, validStudentIdMin);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void IdMustBeBiggerThen10000()
        {
            Student st = new Student(ValidStudentName, validStudentIdMin - 1);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void IdMustBeSmallerThen99999()
        {
            Student st = new Student(ValidStudentName, validStudentIdMax + 1);
        }

    }
}
