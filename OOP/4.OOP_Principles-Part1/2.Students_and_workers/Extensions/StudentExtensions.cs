namespace _2.Students_and_workers.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students_and_workers.Models;

    static class StudentExtensions
    {
        public static List<Student> SortedByGrade(this List<Student> studs)
        {
            return (studs.OrderBy(stud => stud.Grade).ToList());            
        }
    }
}
