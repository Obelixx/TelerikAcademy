
namespace Student_and_Person.Models
{
    using System;

    public enum specialties
    {
        TK,
        KST,
        ID,
        BK,
        MTT,
        MT
    }
    public enum universities
    {
        TU,
        SU,
        MU,
        PU
    }
    public enum faculties
    {
        FTK,
        FKSU,
        FA,
        FPM
    }

    public class Student : ICloneable, IComparable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return this.FirstName + " " + this.MiddleName + " " + this.LastName;
            }
        }

        public ulong SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public int Course { get; set; }

        public specialties Specialty { get; set; }
        public universities University { get; set; }
        public faculties Faculty { get; set; }

        public Student(string firstName, string midName, string lastName, ulong SSN, string permanentAddress, string mobile, string eMail, int course, specialties specialty, universities university, faculties faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = midName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobile;
            this.EMail = eMail;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public override bool Equals(object obj)
        {
            var otherStud = obj as Student;
            if (
                otherStud != null &&
                this.FirstName == otherStud.FirstName &&
                this.MiddleName == otherStud.MiddleName &&
                this.LastName == otherStud.LastName &&
                this.SSN == otherStud.SSN &&
                this.PermanentAddress == otherStud.PermanentAddress &&
                this.MobilePhone == otherStud.MobilePhone &&
                this.EMail == otherStud.EMail &&
                this.Course == otherStud.Course &&
                this.Specialty == otherStud.Specialty &&
                this.University == otherStud.University &&
                this.Faculty == otherStud.Faculty
                )
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return (
                "Student: " + Name + System.Environment.NewLine +
                University + " " + Faculty + " " + Specialty + System.Environment.NewLine +
                "Course: " + Course.ToString() + System.Environment.NewLine +
                "SSN: " + SSN.ToString() + System.Environment.NewLine +
                "Permanent Address: " + PermanentAddress + System.Environment.NewLine +
                "MobilePhone: " + MobilePhone + System.Environment.NewLine +
                "E-Mail: " + EMail + System.Environment.NewLine
            );
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (
                    this.FirstName.GetHashCode() +
                    this.MiddleName.GetHashCode() +
                    this.LastName.GetHashCode() +
                    this.SSN.GetHashCode() +
                    this.PermanentAddress.GetHashCode() +
                    this.MobilePhone.GetHashCode() +
                    this.EMail.GetHashCode() +
                    this.Course.GetHashCode() +
                    this.Specialty.GetHashCode() +
                    this.University.GetHashCode() +
                    this.Faculty.GetHashCode()
                );
            }
        }

        public static bool operator ==(Student stud, Student otherStud)
        {
            return (ReferenceEquals(stud, otherStud) || stud.Equals(otherStud));
        }

        public static bool operator !=(Student stud, Student otherStud)
        {
            return (!(ReferenceEquals(stud, otherStud) || stud.Equals(otherStud)));
        }


        public Student CloneStudent()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone, this.EMail, this.Course, this.Specialty, this.University, this.Faculty);
        }

        public object Clone()
        {
            return this.CloneStudent();
        }


        public int CompareTo(Student otherStud)
        {
            var result = this.Name.CompareTo(otherStud.Name);
            if(result ==0)
            {
                result = this.SSN.CompareTo(otherStud.SSN);
            }
            return result;

        }

        public int CompareTo(object student)
        {
            Student otherStud = student as Student;
            if (otherStud==null)
            {
                throw new ArgumentException("This object is not Student!","student");
            }
            return this.CompareTo(otherStud);
        }
    }
}
