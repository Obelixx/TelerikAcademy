namespace School_classess.Models
{
    using System;
    using School_classess.Interfaces;

    class Student : CommentsImplementation, IPeople
    {
        public string Name { get; set; }
        #region public ulong ClassNumber { get; private set; }

        private static ushort uniqueNumber = ushort.MinValue+1;
        private static ushort UniqueNumber
        {
            get { return uniqueNumber++; }
            set { uniqueNumber = value; }
        }
        private ulong classNumber = 
                                    ulong.Parse(
                                                DateTime.Now.Year.ToString().PadLeft(4,'0') + 
                                                DateTime.Now.Month.ToString().PadLeft(2, '0') + 
                                                DateTime.Now.Day.ToString().PadLeft(2, '0') + 
                                                UniqueNumber.ToString().PadLeft(ushort.MaxValue.ToString().Length, '0')
                                    );
        public ulong ClassNumber { get; private set; }
        #endregion

        public Student(string name)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

    }
}
