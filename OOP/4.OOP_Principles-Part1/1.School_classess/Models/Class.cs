namespace School_classess.Models
{
    using System;
    using System.Collections.Generic;

    class Class : CommentsImplementation
    {
        #region string TextIdentifier //unique text identifier
        private static List<string> IdentifiersMemory = new List<string>();
        private string textIdentifier;

        public string TextIdentifier
        {
            get { return textIdentifier; }
            set
            {
                bool isUnique;
                do
                {
                    isUnique = true;
                    foreach (var id in IdentifiersMemory)
                    {
                        if (value == id)
                        {
                            isUnique = false;
                        }
                    }
                    if (isUnique)
                    {
                        textIdentifier = value;
                        IdentifiersMemory.Add(value);
                    }
                } while (!isUnique);
            }
        }
        #endregion

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public Class(string TextID)
        {
            this.TextIdentifier = TextID;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }

    }
}
