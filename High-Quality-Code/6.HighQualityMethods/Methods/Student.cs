namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Born { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime ourDate;
            DateTime otherDate;
            try
            {
                ourDate = DateTime.Parse(this.Born);
                otherDate = DateTime.Parse(other.Born);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException("Date string cant be empty!");
            }
            catch (FormatException)
            {
                throw new FormatException("Date string does not contain a valid string representation of a date and time. ");
            }

            return ourDate < otherDate;
        }
    }
}
