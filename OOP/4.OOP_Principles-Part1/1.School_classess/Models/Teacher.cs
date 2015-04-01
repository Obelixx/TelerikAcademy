namespace School_classess.Models
{
    using System.Collections.Generic;
    using School_classess.Interfaces;

    class Teacher : CommentsImplementation, IPeople
    {
        public string Name { get; set; }

        internal List<Discipline> Teaches { get; set; }

        public Teacher()
        {
            this.Name = string.Empty;
            this.Teaches = new List<Discipline>();
        }
    }
}
