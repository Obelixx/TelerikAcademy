namespace School
{
    using System;

    public class Student
    {
        private string name;

        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value != null && value != string.Empty)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name can not be empty!");
                }
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    this.id = value;
                }
                else
                {
                    throw new ArgumentException("Id must be between 10 000 and 99 999");
                }
            }
        }
    }
}
