namespace School_classess.Models
{
    class Discipline : CommentsImplementation
    {
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercises { get; set; }

        public Discipline()
        {
            this.Name = string.Empty;
        }
    }
}
