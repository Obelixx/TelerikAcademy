using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SignedStudentHasNextId()
        {
            School school = new School();
            int firstStudentId = school.SignStudent("Pesho");
            int secondStudentId = school.SignStudent("Pesho");
            Assert.IsTrue(firstStudentId+1 == secondStudentId);
        }

        [TestMethod]
        public void Signing90000students()
        {
            School school = new School();
            for (int i = 0; i < 90000; i++)
            {
                int firstStudentId = school.SignStudent("Pesho");
            }
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void Signing90001studentsShouldFail()
        {
            School school = new School();
            for (int i = 0; i < 90001; i++)
            {
                school.SignStudent("Pesho");
            }
        }
    }
}
