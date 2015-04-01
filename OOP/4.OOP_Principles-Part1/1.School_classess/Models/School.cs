namespace School_classess.Models
{
    using System;
    using System.Collections.Generic;

    class School
    {
        public List<Class> Classes { get; set; }

        public School()
        {
            this.Classes = new List<Class>();
        }

    }
}
