namespace School_classess.Models
{
    using School_classess.Interfaces;

    public class CommentsImplementation : IComments
    {
        string comment;
        public string Comment
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.comment))
                {
                    return "[No comments]";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
