
namespace _2.Students_and_workers.Models
{
    class Student : Human
    {
        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName + "\nGrade: " + Grade.ToString());
        }
    }
}
